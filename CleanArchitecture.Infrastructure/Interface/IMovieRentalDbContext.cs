using CleanArchitecture.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Interface
{
    public interface IMovieRentalDbContext
    {
        DbSet<Movie> Movies { get; set; }
    }
}
