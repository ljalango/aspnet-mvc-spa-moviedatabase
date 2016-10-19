using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabaseWebApp.Models
{
    public static class Repository
    {
        public static IEnumerable<Movie> AllMovies()
        {
            var movies = new List<Movie>()
            {
                new Movie { ID = 0, Title = "Raiders of the Lost Ark", CategoryId = 0, Year = 1981, Rating = 7, Description = "Archaeologist and adventurer Indiana Jones is hired by the U.S. government to find the Ark of the Covenant before the Nazis." },
                new Movie { ID = 1, Title = "Memento", CategoryId = 1, Year = 2000, Rating = 9, Description = "A man juggles searching for his wife's murderer and keeping his short-term memory loss from being an obstacle." },
                new Movie { ID = 10, Title = "Trainspotting", CategoryId = 1, Year = 1996, Rating = 8, Description = "Renton, deeply immersed in the Edinburgh drug scene, tries to clean up and get out, despite the allure of the drugs and influence of friends." },
                new Movie { ID = 128, Title = "Viimne reliikvia", CategoryId = 0, Year = 1961, Rating = 6, Description = "" },
                new Movie { ID = 3, Title = "Star Wars: The Force Awakens", CategoryId = 2, Year = 2015, Rating = 4, Description = "Three decades after the defeat of the Galactic Empire, a new threat arises. The First Order attempts to rule the galaxy and only a ragtag group of heroes can stop them, along with the help of the Resistance." },
                new Movie { ID = 2, Title = "Once Upon a Time in Mexico", CategoryId = 4, Year = 1975, Rating = 5, Description = "Hitman 'El Mariachi' becomes involved in international espionage involving a psychotic CIA agent and a corrupt Mexican general." },
                new Movie { ID = 4, Title = "Deepwater Horizon", CategoryId = 1, Year = 2016, Rating = 5, Description = "A dramatization of the April 2010 disaster when the offshore drilling rig, Deepwater Horizon, exploded and created the worst oil spill in U.S. history." },
                new Movie { ID = 96, Title = "Arrival", CategoryId = 2, Year = 2016, Rating = 6, Description = "A linguist is recruited by the military to assist in translating alien communications." },
                new Movie { ID = 55, Title = "Fifty Shades of Grey", CategoryId = 5, Year = 2016, Rating = 3, Description = "Literature student Anastasia Steele's life changes forever when she meets handsome, yet tormented, billionaire Christian Grey." }
            };
            return movies;
        }

        public static IEnumerable<Category> AllGenres()
        {
            var genres = new List<Category>()
            {
                new Category { ID = 0, Name = "action" },
                new Category { ID = 1, Name = "drama" },
                new Category { ID = 2, Name = "sci-fi" },
                new Category { ID = 3, Name = "comedy" },
                new Category { ID = 4, Name = "western" },
                new Category { ID = 5, Name = "horror" },
            };
            return genres;
        }
    }
}
