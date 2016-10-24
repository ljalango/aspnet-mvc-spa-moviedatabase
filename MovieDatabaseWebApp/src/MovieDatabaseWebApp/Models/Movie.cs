using System.Collections.Generic;

namespace MovieDatabaseWebApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CategoryID { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }

        public Movie(int id, string title, int categoryID, int year, int rating, string description)
        {
            this.ID = id;
            this.Title = title;
            this.CategoryID = categoryID;
            this.Year = year;
            this.Rating = rating;
            this.Description = description;
        }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class MovieDetails
    {
        public string title { get; set; }
        public int year { get; set; }
        public int rating { get; set; }
        public string description { get; set; }
    }
}
