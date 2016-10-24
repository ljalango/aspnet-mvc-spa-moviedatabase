
using Microsoft.AspNetCore.Mvc;
using MovieDatabaseWebApp.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieDatabaseWebApp.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieService movieService;

        public MoviesController()
        {
            this.movieService = new  MovieService(new MovieRepository());
        }

        //returns list of movies in JSON using movie service class
        [Route("/api/movies")]
        public JsonResult GetMovies()
        {
            return Json(movieService.GetMovies());
        }

        //returns movie details in JSON using movie service class
        [Route("/api/details")]
        public JsonResult GetMovieDetails(int movieId)
        {
            return Json(movieService.GetMovieDetails(movieId));
        }

        //returns movie category list
        [Route("/api/genres")]
        public JsonResult GetGenres()
        {
            return Json(movieService.GetGenres());
        }
    }
}
