using BlogCentralApp.Models;
using BlogCentralApp.Repositories;
using BlogCentralLib.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace BlogCentralApp.Controllers
{
    public class BlogDetailController : Controller
    {
        private readonly BlogPostRepository _blogPostRepository;

        private readonly AuthorRepository _authorRepository;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly LikeRepository _likeRepository;


        public BlogDetailController(BlogPostRepository blogPostRepository, UserManager<IdentityUser> userManager, AuthorRepository authorRepository, LikeRepository likeRepository)

        {
            _blogPostRepository = blogPostRepository;
            _userManager = userManager;
            _authorRepository = authorRepository;
            _likeRepository = likeRepository;


        }


        [HttpGet]
        public async Task<IActionResult> IndexAsync(int id)

        {

            DetailIndexViewModel vm = new DetailIndexViewModel();

            vm.blogPost = await _blogPostRepository.GetById(id);
            vm.blogPost.Author = await _authorRepository.GetById(vm.blogPost.AuthorId);
            vm.blogPost.Comments = vm.blogPost.Comments.OrderBy(c => c.CreationDate).Reverse();
            vm.Author = (Author)await _userManager.GetUserAsync(User);

            var Likedpost = _likeRepository.GetAll().Where(l => l.BlogPostId == id && l.AuthorId == _userManager.GetUserId(User)).Any();
            if (Likedpost)
            {
                vm.hasLiked = true;

            }
            return View("Detail", vm);
        }
        [HttpGet]
        public async Task<ActionResult> LikeAsync(int id, DetailIndexViewModel vm)
        {
            var Likedpost = _likeRepository.GetAll().Where(l => l.BlogPostId == id && l.AuthorId == _userManager.GetUserId(User)).Any();


            if (Likedpost == false)
            {
                Like newLike = new Like()
                {
                    BlogPostId = id,
                    AuthorId = _userManager.GetUserId(User),

                };
                await _likeRepository.Create(newLike);
                vm.hasLiked = true;
            }

            vm.blogPost = await _blogPostRepository.GetById(id);
            await _blogPostRepository.Like(id);

            vm.Author = (Author)await _userManager.GetUserAsync(User);

            return View("Detail", vm);
        }
        [HttpGet]
        public async Task<ActionResult> UnlikeAsync(int id, DetailIndexViewModel vm)
        {

            var Likedpost = _likeRepository.GetAll().Where(l => l.BlogPostId == id && l.AuthorId == _userManager.GetUserId(User)).FirstOrDefault();


            vm.hasLiked = false;
            await _likeRepository.Delete(Likedpost);
            vm.blogPost = await _blogPostRepository.GetById(id);
            await _blogPostRepository.Unlike(id);

            vm.Author = (Author)await _userManager.GetUserAsync(User);

            return View("Detail", vm);
        }
        [HttpGet]
        public async Task<ActionResult> PostDetail(int id)
        {
            DetailIndexViewModel vm = new DetailIndexViewModel();
            vm.blogPost = await _blogPostRepository.GetById(id);

            vm.Author = (Author)await _userManager.GetUserAsync(User);

            return View("Detail", vm);
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult> CreateEditBlogpost(int? id)
        {
            CreateEditPost vm = new CreateEditPost();

            if (id != null)
            {
                var postFromDb = await _blogPostRepository.GetById(id);

                vm.PostId = (int)id;
                vm.PostContent = postFromDb.Content;
                vm.PostTitle = postFromDb.Title;
                vm.AuthorId = postFromDb.AuthorId;
            }


            vm.Author = (Author)await _userManager.GetUserAsync(User);

            return View("CreateEditPost", vm);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> CreateEditBlogpost(CreateEditPost model)
        {
            if (ModelState.IsValid)
            {
                var _user = await _userManager.GetUserAsync(HttpContext.User);
                if (model.PostId == 0)
                {

                    BlogPost post = new BlogPost()
                    {


                        AuthorId = _user.Id,
                        Author = (Author)_user,
                        Content = model.PostContent,
                        Title = model.PostTitle,
                        Date = DateTime.Now,
                        Likes = 0,
                    };
                    TempData["success"] = "Post created successfully";

                    await _blogPostRepository.Create(post);

                }
                else
                {
                    var postFromDb = await _blogPostRepository.GetById(model.PostId);
                    postFromDb.Content = model.PostContent;
                    postFromDb.Title = model.PostTitle;
                    await _blogPostRepository.Update(postFromDb);
                    TempData["success"] = "Post updated successfully";

                }


                return RedirectToAction("Index1", "Author", new { _user.Id });

            }

            model.Author = (Author)await _userManager.GetUserAsync(HttpContext.User);

            return View("CreateEditPost", model);
        }

        [HttpGet]
        public async Task<IActionResult> DeletePost(int id)
        {
            var _user = await _userManager.GetUserAsync(HttpContext.User);
            await _blogPostRepository.DeleteById(id);
            TempData["success"] = "Post Deleted successfully";


            return RedirectToAction("Index1", "Author", new { _user.Id });
        }

    }
}
