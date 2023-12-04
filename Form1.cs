using System;
using System.Collections.Generic;
using Hqub.Lastfm;
using System.Windows.Forms;
using Hqub.Lastfm.Entities;
using System.Linq;

namespace SongInfoTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // Parent object
        static LastfmClient client = new LastfmClient("cc9eb261fc35326d97d7492dda22bdf5");

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            btnGenerate.Enabled = txtSong.Text != "" && txtArtist.Text != "";
        }

        private async void GetSongInfos(string music, string artist)
        {
            try
            {
                Track track = await client.Track.GetInfoAsync(music, artist);
                lblError.Hide();

                // Put the image on the left of the app
                albumDisplayed.ImageLocation = track.Album.Images[3].Url;

                // Put the song's top genre (lastfm tag)
                lblTag.Text = "Song genre: ";

                List<Tag> tags = await client.Track.GetTopTagsAsync(txtSong.Text, txtArtist.Text);
                lblTag.Text += tags.First().Name;
            }
            catch (Exception e) // Error handling //
            {
#if DEBUG
                Console.WriteLine("Oops something happened: " + e.Message);
#endif
                lblError.Show();
            }
        }

        private void btnGenerate_ClickAsync(object sender, EventArgs e)
        {
            GetSongInfos(txtSong.Text, txtArtist.Text);
        }

        private void llblCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.last.fm/api");
        }
    }
}
