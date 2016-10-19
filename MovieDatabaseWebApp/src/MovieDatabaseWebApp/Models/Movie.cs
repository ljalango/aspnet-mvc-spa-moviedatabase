namespace MovieDatabaseWebApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
