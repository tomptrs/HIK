using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EntityFrameworkCore.Models
{
    public class vmListMovies
    {
        public ICollection<Movie> Movies { get; set; }
        public SelectList Ratings { get; set; }
        public int? RatingId { get; set; }
    }
}
