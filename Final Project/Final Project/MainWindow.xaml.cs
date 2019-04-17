using System;
using System.Collections.Generic;
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

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Song> songList;

        public MainWindow()
        {
            InitializeComponent();

            songList = new List<Song>();
        }

        private void AddSongButton_Click(object sender, RoutedEventArgs e)
        {
            string name = SongTitleTextBox.Text;
            string artist = ArtistTextBox.Text;
            SongTitleTextBox.Clear();
            ArtistTextBox.Clear();

            Song newMovie = new Song(name, artist);

            songList.Add(newMovie);
        }

        private void ShowAllButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Song song in songList)
            {
                song.ShowSong();
                song.ShowArtist();
            }
        }
    }
}
