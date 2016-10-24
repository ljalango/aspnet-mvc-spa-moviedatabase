using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabaseWebApp.Models
{
    public interface IMovieService
    {
        MovieList GetMovies();
        MovieDetails GetMovieDetails(int movieId);
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

        public MovieDetails GetMovieDetails(int movieId)
        {
            //return movie details from movie repository by id
            Movie movie = this.movieRepository.GetMovieById(movieId);

            MovieDetails details = new MovieDetails();
            details.title = movie.Title;
            details.year = movie.Year;
            details.rating = movie.Rating;
            details.description = movie.Description;

            return details;
        }

        public List<Category> GetGenres()
        {
            return this.movieRepository.AllGenres();
        }

    }
}
