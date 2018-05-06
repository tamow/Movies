using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "タイトル")]
        [Required(ErrorMessage = "タイトルは必須です。")]
        public string Title { get; set; }
        [Display(Name = "リリース日")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "リリース日は必須です。")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "ジャンル")]
        public string Genre { get; set; }
        [Display(Name = "価格")]
        [Required(ErrorMessage = "価格は必須です。")]
        public decimal Price { get; set; }

    }
}