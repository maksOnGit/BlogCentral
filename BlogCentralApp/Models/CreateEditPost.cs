﻿using System.ComponentModel.DataAnnotations;

namespace BlogCentralApp.Models
{
    public class CreateEditPost
    {
        public int PostId { get; set; }
        [Required]
        [Display(Name ="Title")]
        public string PostTitle { get; set; }
        [Display(Name = "Content")]
        public string PostContent { get; set; }
        public string AuthorId { get; set; }

    }
}
