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

        public List<Category> GetGenres()
        {
            return this.movieRepository.AllGenres();
        }

    }
}
