using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class MovieViewModel
    {
        public List<Movie> movies;

        [Display(Name = "検索文字")]
        public string SearchString { get; set; }

        [Display(Name = "ジャンル")]
        public string Genres { get; set; }

    }
}