using Microsoft.EntityFrameworkCore;
using static Mission4ASP.Models.MoviesResponse;

namespace Mission4ASP.Models
{
    public class MovieEnterContext : DbContext
    {
        // Constructor
        public MovieEnterContext(DbContextOptions<MovieEnterContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<MoviesResponse> Entries { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
            );

            mb.Entity<MoviesResponse>().HasData(

                new MoviesResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "Pirates of the Caribbean: Curse of the Black Pearl",
                    Year = 2003,
                    Director = "Gore Verbinski",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MoviesResponse
                {
                    MovieID = 2,
                    CategoryID = 1,
                    Title = "Revenge of the Sith",
                    Year = 2005,
                    Director = "George Lucas",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },

                new MoviesResponse
                {
                    MovieID = 3,
                    CategoryID = 3,
                    Title = "Little Women",
                    Year = 2019,
                    Director = "Greta Gerwig",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }
    }
}
// this is branch mission 5