using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>());

        if (context.Movie.Any())
        {
            return;
        }

        context.Movie.AddRange(
            new Movie
            {
                Title = "When Harry Met Sally",
                ReleaseDate = DateTime.Parse("1989-2-12"),
                Genre = "Romantic Comedy",
                Rating = "P",
                Price = 7.99M
            },
            new Movie
            {
                Title = "Ghostbusters ",
                ReleaseDate = DateTime.Parse("1984-3-13"),
                Genre = "Comedy",
                Rating = "C",
                Price = 8.99M
            },
            new Movie
            {
                Title = "Ghostbusters 2",
                ReleaseDate = DateTime.Parse("1986-2-23"),
                Genre = "Comedy",
                Rating = "R",
                Price = 9.99M
            },
            new Movie
            {
                Title = "Rio Bravo",
                ReleaseDate = DateTime.Parse("1959-4-15"),
                Genre = "Western",
                Rating = "K",
                Price = 3.99M
            },
             new Movie
            {
                Title = "Jaws",
                ReleaseDate = DateTime.Parse("1975-6-20"),
                Genre = "Thriller",
                Rating = "PG",
                Price = 8.00M
            },
              new Movie
            {
                Title = "The Matrix",
                ReleaseDate = DateTime.Parse("1999-3-31"),
                Genre = "Science Fiction",
                Rating = "R",
                Price = 12.00M
            },
              new Movie
            {
                Title = "Titanic",
                ReleaseDate = DateTime.Parse("1997-12-19"),
                Genre = "Romance",
                Rating = "PG-13",
                Price = 13.00M
            }
        );

        context.SaveChanges();
    }
}