using MyWatchList.Models;

namespace MyWatchList.Services
{
    public class MovieService : IMovieService
    {
        private readonly DatabaseContext _ctx;

        public MovieService(DatabaseContext ctx)
        {
            _ctx = ctx;
        }

        public bool AddUpdate(Movie movie)
        {
            try
            {
                if (movie.Id == 0)
                    _ctx.Movie.Add(movie);
                else
                    _ctx.Movie.Update(movie);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var movie = FindByid(id);
                if (movie == null)
                    return false;
                _ctx.Movie.Remove(movie);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Movie FindByid(int id)
        {
            return _ctx.Movie.Find(id);
        }

        public List<Movie> GetAll()
        {
            return _ctx.Movie.ToList();
        }
    }
}