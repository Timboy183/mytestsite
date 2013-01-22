namespace Mytestproject.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(
                new Movie
                {
                    Title = "Never Quit, You Will Win",
                    ReleaseDate = DateTime.Parse("2013-2-2"),
                    Genre = "Emotional",
                    Rating = "G",
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "From Rats To Riches",
                    ReleaseDate = DateTime.Parse("2013-9-1"),
                    Genre = "Motivational",
                    Rating = "PG",
                    Price = 12.99M

                });
          
        }
    }
}
