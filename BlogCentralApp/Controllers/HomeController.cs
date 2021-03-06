using BlogCentralApp.Models;
using BlogCentralApp.Repositories;
using BlogCentralLib.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogCentralApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly BlogPostRepository _blogPostRepository;


        private readonly SignInManager<IdentityUser> _signManager;

        private readonly UserManager<IdentityUser> _userManager;
      private readonly VisitorRepository _visitorRepository;
        private readonly VisitRepository _visitRepository;


        public HomeController(BlogPostRepository blogPostRepository, SignInManager<IdentityUser> signInManager,UserManager<IdentityUser>userManager,VisitorRepository visitorRepository,VisitRepository visitRepository)
        {
            _blogPostRepository = blogPostRepository;
            _signManager = signInManager;
            _userManager = userManager;
            _visitorRepository = visitorRepository;
            _visitRepository = visitRepository;
           

        }

        [HttpGet]
        public async Task<IActionResult> Index1()
        {
            var userId=HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value??Guid.NewGuid().ToString();

            if (!_visitorRepository.GetAll().Any(v => v.UserId == userId))
            {

                await _visitorRepository.Create(new Visitor { UserId = userId });
            }

            await _visitRepository.Create(new Visit());


           

           
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            
          
            HomePageViewModel vm = new HomePageViewModel();


            vm.StartOfSelection = true;
            vm.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Date).ToList().Take(6);

            HttpContext.Response.Cookies.Append("count", "6");
            HttpContext.Response.Cookies.Append("lastSort", "Newest first");


            if (_signManager.IsSignedIn(User))
            {
                vm.Author = (Author)await _userManager.GetUserAsync(User);
            }
           
            return View("index", vm);
        }





        public async Task<IActionResult> Detail(int id)
        {
            return RedirectToAction("IndexAsync", "BlogDetail", id);
        }

        public async Task<IActionResult> Next10(HomePageViewModel model)
        {
            model = new HomePageViewModel();
            model.StartOfSelection = false;

            int countShow;
            int range = _blogPostRepository.GetAll().Count() - int.Parse(HttpContext.Request.Cookies["count"]);

            if (range <= 9 )
            {
                countShow = _blogPostRepository.GetAll().Count();
                model.EndOfSelection = true;
            }
            else
            {

                    range = 10;
                    countShow = int.Parse(HttpContext.Request.Cookies["count"]) + 10;
                    model.EndOfSelection = false;
            }

            HttpContext.Response.Cookies.Append("count", countShow.ToString());

            switch (HttpContext.Request.Cookies["lastSort"])
            {

                    case "Oldest first":
                        model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderBy(x => x.Date).ToList().GetRange(int.Parse(HttpContext.Request.Cookies["count"]), range);
                        break;

                    case "Most popular First":
                        model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Likes).ToList().GetRange(int.Parse(HttpContext.Request.Cookies["count"]), range);
                        break;

                    default:
                        model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Date).ToList().GetRange(int.Parse(HttpContext.Request.Cookies["count"]), range);
                        break;
            }
          


            return View("index", model);
        }

        public async Task<IActionResult> Previous10(HomePageViewModel model)
        {
            model = new HomePageViewModel();
            model.EndOfSelection = false;

            int range = int.Parse(HttpContext.Request.Cookies["count"]) - 10;
            
            if (range <= 11)
            {
                return RedirectToAction("First10");
            }
            else
            {
                HttpContext.Response.Cookies.Append("count", range.ToString());

                switch (HttpContext.Request.Cookies["lastSort"])
                {
                    case "Oldest first":
                        model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderBy(x => x.Date).ToList().GetRange(int.Parse(HttpContext.Request.Cookies["count"]) - 20, 10);
                        break;

                    case "Most popular First":
                        model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Likes).ToList().GetRange(int.Parse(HttpContext.Request.Cookies["count"]) - 20, 10);
                        break;

                    default:
                        model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Date).ToList().GetRange(int.Parse(HttpContext.Request.Cookies["count"]) - 20, 10);
                        break;
                }
               

                return View("index", model);
            }
        }

        public async Task<IActionResult> Last10(HomePageViewModel model)
        {

            model = new HomePageViewModel();
            model.EndOfSelection = true;

            int countShow = _blogPostRepository.GetAll().Count();

            HttpContext.Response.Cookies.Append("count", countShow.ToString());
            
            if (countShow <= 10)
            {
                model.StartOfSelection = true;
            }
            else
            {
                model.StartOfSelection = false;
            }

            switch (HttpContext.Request.Cookies["lastSort"])
            {
                case "Oldest first":
                    model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderBy(x => x.Date).ToList().TakeLast(10);
                    break;

                case "Most popular First":
                    model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Likes).ToList().TakeLast(10);
                    break;

                default:
                    model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Date).ToList().TakeLast(10);
                    break;
            }
           

            return View("index", model);
        }

        public async Task<IActionResult> First10(HomePageViewModel model)
        {

            model = new HomePageViewModel();
            model.StartOfSelection = true;

            int countShow = _blogPostRepository.GetAll().Count();

            HttpContext.Response.Cookies.Append("count", "10");
            
            if (countShow <= 10)
            {
                HttpContext.Response.Cookies.Append("count", countShow.ToString());
                model.EndOfSelection = true;
            }
            else
            {
                HttpContext.Response.Cookies.Append("count", "10");
                model.EndOfSelection = false;
            }

            switch (HttpContext.Request.Cookies["lastSort"])
            {
                case "Oldest first":
                    model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderBy(x => x.Date).ToList().Take(10);
                    break;

                case "Most popular First":
                    model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Likes).ToList().Take(10);
                    break;

                default:
                    model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Date).ToList().Take(10);
                    break;
            }
            

          

            return View("index", model);
        }

        [HttpPost]
        public async Task<IActionResult> Sort(HomePageViewModel model)
        {
            int countShow = _blogPostRepository.GetAll().Count();

            switch (model.Sort)
            {
                case "Oldest first":
                    HttpContext.Response.Cookies.Append("lastSort", "Oldest first");
                    model = new HomePageViewModel();
                    model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderBy(x => x.Date).ToList().Take(6);
                    break;

                case "Most popular First":
                    HttpContext.Response.Cookies.Append("lastSort", "Most popular First");
                    model = new HomePageViewModel();
                    model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Likes).ToList().Take(6);
                    break;

                default:
                    HttpContext.Response.Cookies.Append("lastSort", "Newest first");
                    model = new HomePageViewModel();
                    model.BlogPosts = _blogPostRepository.GetAll().Include(b => b.Author).ToList().OrderByDescending(x => x.Date).ToList().Take(6);
                    break;
            }
           

            if (countShow <= 6)
            {
                HttpContext.Response.Cookies.Append("count", countShow.ToString());
                model.EndOfSelection = true;
            }
            else
            {
                HttpContext.Response.Cookies.Append("count", "6");
                model.EndOfSelection = false;
            }

            model.StartOfSelection = true;
           

            return View("index", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
