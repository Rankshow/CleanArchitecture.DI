using CleanArchitecture.Infrastructure.Interface;
using CleanArchitecture.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitecture.Infrastructure.Data
{
    public class MovieRentalDbContext : DbContext, IMovieRentalDbContext
    {
        public MovieRentalDbContext(DbContextOptions<MovieRentalDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Movie> Movies { get ; set ; }
    }
}
