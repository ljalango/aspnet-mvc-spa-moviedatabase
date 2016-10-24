
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieDatabaseWebApp.Models;

namespace UnitTests
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

            MovieDetails details = service.GetMovieDetails(271);
            Assert.AreEqual("Renegade", service.GetMovieDetails(0).title);
        }

    }
}
