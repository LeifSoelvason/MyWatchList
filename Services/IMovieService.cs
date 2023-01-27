using Microsoft.AspNetCore.Identity;
using MyWatchList.Models;

namespace MyWatchList.Services
{
    public interface IMovieService
    {
        bool AddUpdate(Movie movie);

        bool Delete(int id);

        Movie FindByid(int id);

        List<Movie> GetAll();
    }
}
