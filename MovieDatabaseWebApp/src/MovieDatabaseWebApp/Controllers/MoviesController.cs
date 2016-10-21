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
        [Route("/api/movies")]
        public JsonResult GetMovies()
        {
            MoviesModel model = new MoviesModel();
            return Json(model.Movies);
        }

        [Route("/api/movie")]
        public JsonResult GetMovieById(int movieId)
        {
            MoviesModel model = new MoviesModel();
            return Json(model.GetMovieById(movieId));
        }
    }
}
