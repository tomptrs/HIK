using EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data
{
    public class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();

            // Look for any movies
            if (context.Movies.Any())
            {
                return;
            }

            context.Ratings.AddRange(
                new Rating { Code = "G", Name="General" },
                new Rating { Code = "PG", Name = "Parental Guidance" },
                new Rating { Code = "M", Name = "Mature" }
                );

            context.SaveChanges();

            context.Movies.AddRange(
                new Movie { Title = "When Harry met Sally", ReleaseDate = DateTime.Parse("1989-1-11"), Genre="Romantic Comedy", Price = 8, RatingID = 1 },
                new Movie { Title = "Ghostbusters", ReleaseDate = DateTime.Parse("1984-3-13"), Genre = "Comedy", Price = 9, RatingID = 1 },
                new Movie { Title = "Ghostbusters 2", ReleaseDate = DateTime.Parse("1986-2-23"), Genre = "Comedy", Price = 8, RatingID = 1 }
                );

            context.SaveChanges();
        }
    }
}
