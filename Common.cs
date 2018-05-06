using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie
{
    public class Common
    {
        public IEnumerable<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem { Text = "Comedy", Value = "Comedy" },
            new SelectListItem { Text = "Romantic Comedy", Value = "Romantic Comedy" },
            new SelectListItem { Text = "Western", Value = "Western" }
        };
    }
}