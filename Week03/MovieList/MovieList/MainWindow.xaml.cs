using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Movie> movieList;

        public MainWindow()
        {
            InitializeComponent();

            movieList = new List<Movie>();
        }

        private void buttonAddMovie_Click(object sender, RoutedEventArgs e)
        {
            string name = textBox.Text;
            int year = Convert.ToInt32(textBoxReleaseYear.Text);
            string director = textBoxDirector.Text;
            int length = Convert.ToInt32(textBoxLength);
            textBox.Clear();
            textBoxReleaseYear.Clear();
            textBoxDirector.Clear();
            textBoxLength.Clear();

            Movie newMovie = new Movie(name, year, director, length);

            movieList.Add(newMovie);
        }

        private void buttonShowAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in movieList)
            {
                movie.ShowMovie();
            }
        }
    }
}
