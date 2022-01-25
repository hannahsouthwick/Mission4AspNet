using Microsoft.EntityFrameworkCore;
using static Mission4ASP.Models.Movies;

namespace Mission4ASP.Models
{
    public class MovieEnterContext : DbContext
    {
        // Constructor
        public MovieEnterContext(DbContextOptions<MovieEnterContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<MoviesResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MoviesResponse>().HasData(

                new MoviesResponse
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "Pirates of the Caribbean",
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
                    Category = "Action/Adventure",
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
                    Category = "Drama",
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
