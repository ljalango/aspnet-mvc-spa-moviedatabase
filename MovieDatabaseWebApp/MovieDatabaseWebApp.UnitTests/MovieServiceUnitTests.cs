﻿
using MovieDatabaseWebApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MovieDatabaseWebApp.UnitTests
{
    [TestClass]
    public class MovieServiceUnitTests
    {

        [TestMethod]
        public void TestGetMovies()
        {
            IMovieService service = new MovieService(new MovieRepository());

            Assert.AreNotEqual(0, service.GetMovies().Count);
        }

        [TestMethod]
        public void TestGetMovieDetails()
        {
            MovieService service = new MovieService(new MovieRepository());

            MovieDetails details = service.GetMovieDetails(0);
            Assert.AreNotEqual(0, service.GetMovieDetails());
        }

    }
}
