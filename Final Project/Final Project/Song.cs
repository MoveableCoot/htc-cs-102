using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Final_Project
{
    public class Song
    {
        private string songName;
        private string artist;
        
        public Song(string name, string artist)
        {
            songName = name;
            artist = artist;
        }

        public void ShowSong()
        {
            MessageBox.Show(songName);
        }

        public void ShowArtist()
        {
            MessageBox.Show(artist);
        }
    }
}
