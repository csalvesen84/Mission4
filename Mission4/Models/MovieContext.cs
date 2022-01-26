using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Seeding the database with some movies when first created
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
                    Title = "Star Wars Episode III: Revenge of the Sith",
                    Year = 2005,
                    Director = "George Lucas",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new Movie
                {
                    MovieId = 2,
                    Category = "Comedy",
                    Title = "Napoleon Dynamite",
                    Year = 2004,
                    Director = "Jared Hess",
                    Rating = "PG",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new Movie
                {
                    MovieId = 3,
                    Category = "Western",
                    Title = "Django Unchained",
                    Year = 2012,
                    Director = "Quentin Tarantino",
                    Rating = "R",
                    Edited = true,
                    LentTo = null,
                    Notes = null
                },
                new Movie
                {
                    MovieId = 4,
                    Category = "Action/Comedy",
                    Title = "Kingsman: The Secret Service",
                    Year = 2014,
                    Director = "Matthew Vaughn",
                    Rating = "R",
                    Edited = true,
                    LentTo = null,
                    Notes = null
                }
            );
        }
    }
}
