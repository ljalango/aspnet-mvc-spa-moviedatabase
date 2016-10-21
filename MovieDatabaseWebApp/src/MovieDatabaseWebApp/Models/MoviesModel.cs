using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabaseWebApp.Models
{
    public class MoviesModel
    {
        public IEnumerable<Category> Genres { get; set; }
        public IEnumerable<Movie> Movies { get; set; }

        public MoviesModel()
        {
            this.Movies = Repository.AllMovies();
        }

        public IEnumerable<Movie> GetMovies()
        {
            return this.Movies;
        }

        public Movie GetMovieById(int movieId)
        {
            var mov = this.Movies.FirstOrDefault(m => m.ID.Equals(movieId));
            return mov;
        }

        public IEnumerable<Category> GetGenres()
        {
            return Repository.AllGenres();
        }
    }
}
