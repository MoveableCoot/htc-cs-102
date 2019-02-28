using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        private string movieName;
        private int releaseYear;
        private string director;
        private int length;

        public Movie(string name, int releaseYear, string director, int length)
        {
            this.movieName = name;
            this.releaseYear = releaseYear;
            director = director;
            length = length;
        }

        public void ShowMovie()
        {
            MessageBox.Show(movieName + Environment.NewLine + releaseYear);
        }
    }
}
