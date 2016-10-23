using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [Route("/api/details")]
        //returns movie details in JSON using movie service class
        public JsonResult GetMovieDetails(int movieId)
        {
            return Json(movieService.GetMovieDetails(movieId));
        }

        [Route("/api/search")]
        //returns list of movies in JSON using movie service class
        public JsonResult FindMovies(string keyword)
        {
            return Json(movieService.GetMoviesByKeyword(keyword));
        }

        [Route("/api/genres")]
        public JsonResult GetGenres()
        {
            return Json(movieService.GetGenres());
        }
    }
}
