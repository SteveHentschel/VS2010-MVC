namespace MovieDB_MVC4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MovieDB_MVC4.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieDB_MVC4.Models.Movie1DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieDB_MVC4.Models.Movie1DBContext context)
        {
            context.Movies1.AddOrUpdate(i => i.Title,
        new Movie
        {
            Title = "When Harry Met Sally",
            ReleaseDate = DateTime.Parse("1989-1-11"),
            Genre = "Drama",
            Price = 7.99M,
            Rating = "PG"
        },

         new Movie
         {
             Title = "Ghostbusters ",
             ReleaseDate = DateTime.Parse("1984-3-13"),
             Genre = "Comedy",
             Price = 8.99M,
             Rating = "NC-17"
         }
         );
        }
    }
}
