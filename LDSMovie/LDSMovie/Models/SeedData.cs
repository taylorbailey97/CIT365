using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDSMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LDSMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<LDSMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "17 Miracles",
                         ReleaseDate = DateTime.Parse("2011-6-3"),
                         Genre = "History Adventure",
                         Rating = "G",
                         Price = 7.99M
                     },

                     new Movie
                     {
                         Title = "The Best Two Years",
                         ReleaseDate = DateTime.Parse("2003-3-13"),
                         Genre = "Comedy Drama",
                         Rating = "G",
                         Price = 8.99M
                     },

                     new Movie
                     {
                         Title = "The R.M.",
                         ReleaseDate = DateTime.Parse("2003-1-31"),
                         Genre = "Comedy",
                         Rating = "PG",
                         Price = 9.99M
                     },

                   new Movie
                   {
                       Title = "Meet the Mormons",
                       ReleaseDate = DateTime.Parse("2014-10-10"),
                       Genre = "Documentry",
                       Rating = "G",
                       Price = 11.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
