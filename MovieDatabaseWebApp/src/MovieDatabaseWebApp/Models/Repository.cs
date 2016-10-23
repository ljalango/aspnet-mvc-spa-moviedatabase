using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabaseWebApp.Models
{
    public interface IMovieRepository
    {
        MovieList AllMovies();
        Movie GetMovieById(int movieId);
        List<Category> AllGenres();
    } 

    public class MovieRepository: IMovieRepository
    {
        private MovieList Movies;
        private List<Category> Genres;

        public MovieRepository()
        {
            this.Movies = new MovieList()
            {
                new Movie(0, "Raiders of the Lost Ark", (int)Genre.action, 1981, 7, "Archaeologist and adventurer Indiana Jones is hired by the U.S. government to find the Ark of the Covenant before the Nazis."),
                new Movie(1, "Memento", (int)Genre.thriller, 2000, 9, "A man juggles searching for his wife's murderer and keeping his short-term memory loss from being an obstacle."),
                new Movie(10, "Trainspotting", (int)Genre.drama, 1996, 8, "Renton, deeply immersed in the Edinburgh drug scene, tries to clean up and get out, despite the allure of the drugs and influence of friends."),
                new Movie(128, "Viimne reliikvia", (int)Genre.adventure, 1969, 6, ""),
                new Movie(3, "Star Wars: The Force Awakens", (int)Genre.scifi, 2015, 4, "Three decades after the defeat of the Galactic Empire, a new threat arises. The First Order attempts to rule the galaxy and only a ragtag group of heroes can stop them, along with the help of the Resistance."),
                new Movie(2, "Once Upon a Time in Mexico", (int)Genre.crime, 2003, 5, "Hitman 'El Mariachi' becomes involved in international espionage involving a psychotic CIA agent and a corrupt Mexican general."),
                new Movie(4, "Deepwater Horizon", (int)Genre.drama, 2016, 5, "A dramatization of the April 2010 disaster when the offshore drilling rig, Deepwater Horizon, exploded and created the worst oil spill in U.S. history."),
                new Movie(96, "Arrival", (int)Genre.scifi, 2016, 6, "A linguist is recruited by the military to assist in translating alien communications."),
                new Movie(55, "Fifty Shades of Grey", (int)Genre.horror, 2016, 3, "Literature student Anastasia Steele's life changes forever when she meets handsome, yet tormented, billionaire Christian Grey."),
                new Movie(5, "Extinction", (int)Genre.thriller, 2015, 7, "And suddenly, overnight, the world came to a halt. Two men, two survivors, one kid, and hatred that separates them. A place forgotten by everyone, including the creatures that inhabit the Earth... until now"),
                new Movie(6, "Terminus", (int)Genre.scifi, 2015, 9, "Following a near-fatal accident, David Chamberlain makes an unprecedented discovery that will not only determine the fate of his family, but of mankind."),
                new Movie(22, "Sky", (int)Genre.drama, 2015, 8, "Romy (Diane Kruger) is on holiday in the USA with her French husband, Richard (Gilles Lellouche). But the journey quickly turns into a settling of old scores for this worn out couple. After an ultimate fight, Romy decides to break free. She cuts off her ties to a stable and secure life that has become alienating and escapes to the unknown"),
                new Movie(23, "Vacation", (int)Genre.comedy, 2015, 6, "Rusty Griswold takes his own family on a road trip to 'Walley World' in order to spice things up with his wife and reconnect with his sons."),
                new Movie(234, "Journey to the Edge of the Universe", (int)Genre.documentary, 2008, 9, "Voyage on images taken from the Hubble telescope. Explore the science and history behind the distant celestial bodies in the solar system. Narrated by Alec Baldwin"),
                new Movie(25, "Dinosaur", (int)Genre.animation, 2000, 7, "An orphaned dinosaur raised by lemurs joins an arduous trek to a sancturary after a meteorite shower destroys his family home."),
                new Movie(26, "Sleepy Hollow", (int)Genre.horror, 1999, 8, "Ichabod Crane is sent to Sleepy Hollow to investigate the decapitations of 3 people with the culprit being the legendary apparition, the Headless Horseman."),
                new Movie(271, "Renegade", (int)Genre.western, 2004, 8, "Alledged wayward adolescent Louisiana gentleman Michael 'Mike' Blueberry is dumped by his family with a Wild West uncle. ")
            };
            this.Genres = new List<Category>()
            {
                new Category { ID = (int)Genre.all, Name = "ALL" },
                new Category { ID = (int)Genre.action, Name = "ACTION" },
                new Category { ID = (int)Genre.drama, Name = "DRAMA" },
                new Category { ID = (int)Genre.scifi, Name = "SCI-FI" },
                new Category { ID = (int)Genre.comedy, Name = "COMEDY" },
                new Category { ID = (int)Genre.western, Name = "WESTERN" },
                new Category { ID = (int)Genre.horror, Name = "HORROR" },
                new Category { ID = (int)Genre.thriller, Name = "THRILLER" },
                new Category { ID = (int)Genre.adventure, Name = "ADVENTURE" },
                new Category { ID = (int)Genre.crime, Name = "CRIME" },
                new Category { ID = (int)Genre.documentary, Name = "DOCUMENTARY" },
                new Category { ID = (int)Genre.animation, Name = "ANIMATION" }
            };
        }

        //return movie by id (from the hard coded list)
        public Movie GetMovieById(int movieId)
        {
            var movie = this.Movies.FirstOrDefault(m => m.ID.Equals(movieId));
            return movie;
        }

        //return fixed (hard coded) list of movies
        public MovieList AllMovies()
        {
            return this.Movies;
        }

        public List<Category> AllGenres()
        {
            return this.Genres;
        }

        enum Genre
        {
            all, action, drama, scifi, comedy, western, horror, thriller, adventure, crime, documentary, animation
        }
    }
}
