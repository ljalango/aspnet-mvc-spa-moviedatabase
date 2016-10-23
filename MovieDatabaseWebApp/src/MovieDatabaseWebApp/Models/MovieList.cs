using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabaseWebApp.Models
{
    public class MovieList : IList<Movie>
    {
        private List<Movie> movieList = new List<Movie>();

        public Movie this[int index]
        {
            get
            {
                return ((IList<Movie>)movieList)[index];
            }

            set
            {
                ((IList<Movie>)movieList)[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return ((IList<Movie>)movieList).Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ((IList<Movie>)movieList).IsReadOnly;
            }
        }

        public void Add(Movie item)
        {
            ((IList<Movie>)movieList).Add(item);
        }

        public void Clear()
        {
            ((IList<Movie>)movieList).Clear();
        }

        public bool Contains(Movie item)
        {
            return ((IList<Movie>)movieList).Contains(item);
        }

        public void CopyTo(Movie[] array, int arrayIndex)
        {
            ((IList<Movie>)movieList).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Movie> GetEnumerator()
        {
            return ((IList<Movie>)movieList).GetEnumerator();
        }

        public int IndexOf(Movie item)
        {
            return ((IList<Movie>)movieList).IndexOf(item);
        }

        public void Insert(int index, Movie item)
        {
            ((IList<Movie>)movieList).Insert(index, item);
        }

        public bool Remove(Movie item)
        {
            return ((IList<Movie>)movieList).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<Movie>)movieList).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<Movie>)movieList).GetEnumerator();
        }
    }
}
