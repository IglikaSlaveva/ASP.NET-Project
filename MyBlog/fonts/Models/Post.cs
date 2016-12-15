using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Вино")]
        public string Title { get; set; }
       


        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public string Body { get; set; }

        [Required]
        
        public DateTime Date { get; set; }

        public ApplicationUser Author { get; set; }
    }
}