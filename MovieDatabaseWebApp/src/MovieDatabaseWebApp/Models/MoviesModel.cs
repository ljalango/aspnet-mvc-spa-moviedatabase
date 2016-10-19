using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabaseWebApp.Models
{
    public class MoviesModel
    {
        public IEnumerable<Category> Genres { get; set; }

        public IEnumerable<Movie> GetMovies()
        {
            return Repository.AllMovies();
        }

        public IEnumerable<Category> GetGenres()
        {
            return Repository.AllGenres();
        }
    }
}
