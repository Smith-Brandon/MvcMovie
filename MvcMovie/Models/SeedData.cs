using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Autobiography ",
                        Rating = "PG 13",
                        Price = 16.99M
                    },

                    new Movie
                    {
                        Title = "Christmas in Conway",
                        ReleaseDate = DateTime.Parse("2013-12-1"),
                        Genre = "Romantic",
                        Rating = "PG",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Christmas Jars",
                        ReleaseDate = DateTime.Parse("2019-11-4"),
                        Genre = "Drama",
                        Rating = "G",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Jonah and the Great Fish",
                        ReleaseDate = DateTime.Parse("2011-11-15"),
                        Genre = "Family",
                        Rating = "G",
                        Price = 14.95M
                    },
                    
                    new Movie
                     {
                         Title = "Carthage",
                         ReleaseDate = DateTime.Parse("2017-9-29"),
                         Genre = "Drama",
                         Rating = "PG 13",
                         Price = 11.99M
                     }
                );
                context.SaveChanges();
            }
        }
    }
}