using System;
using System.Collections.Generic;
using Hqub.Lastfm;
using System.Windows.Forms;
using Hqub.Lastfm.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;
using System.Reflection;

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

        private async Task<Track> GetTrack(string song, string artist)
        {
            try
            {
                Track track = await client.Track.GetInfoAsync(song, artist);
                return track;

            }
            catch (Exception e) // If the track is not found return null
            {
                return null;
            }
        }

        private string GetAlbum(Track track)
        {
            try
            {
                // string album =
                return track.Album.Images[3].Url;
                // return album;
            }
            catch (Exception e) { return null; }
        }

        private async Task<string> GetTopTag(string song, string artist)
        {
            try
            {
                List<Tag> tags = await client.Track.GetTopTagsAsync(song, artist);
                return tags.First().Name;
            }
            catch (Exception e) { return null; }
        }

        private async void GetSongInfos(string song, string artist)
        {
            Track track = await GetTrack(song, artist);
            string album = GetAlbum(track);
            string topTag = await GetTopTag(song, artist);

            if (track != null) // Only works if the track is found
            {
                lblError.Hide();

                // Display the image on the left of the app
                if (album != null) // Only works if the album cover is found
                {
                    albumDisplayed.ImageLocation = album;
                    lblAlbumNotFound.Visible = false;
                }
                else lblAlbumNotFound.Visible = true;

                // Display the song's top genre (last.fm tag)
                if (topTag != null)
                    lblTag.Text = "Song genre: " + topTag;
                else lblTag.Text = "No song genre found";

            }
            else lblError.Show();
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
