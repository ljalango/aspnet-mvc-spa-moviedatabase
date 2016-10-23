using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabaseWebApp.Models
{
    public interface IMovieService
    {
        MovieList GetMovies();
        object GetMovieDetails(int movieId);
        object GetMoviesByKeyword(string keyword);
        List<Category> GetGenres();
    }

    public class MovieService : IMovieService
    {
        private IMovieRepository movieRepository;

        public MovieService() : this(new MovieRepository()) { }

        public MovieService(IMovieRepository repository)
        {
            this.movieRepository = repository;
        }

        public MovieList GetMovies()
        {
            //return list of movies from Repository class method
            return this.movieRepository.AllMovies();
        }

        public object GetMovieDetails(int movieId)
        {
            //return from movie repository by id
            var queryResult = from item in this.movieRepository.AllMovies()
                        where item.ID == movieId
                        select item;
            return queryResult.Single();
        }

        public object GetMoviesByKeyword(string keyword)
        {
            var queryResults = movieRepository.AllMovies().Where(mov => mov.Title.Equals(keyword)).ToList();
            return queryResults;
        }

        public List<Category> GetGenres()
        {
            return this.movieRepository.AllGenres();
        }

    }
}
