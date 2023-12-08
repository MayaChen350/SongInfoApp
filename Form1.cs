using System;
using System.Collections.Generic;
using Hqub.Lastfm;
using System.Windows.Forms;
using Hqub.Lastfm.Entities;
using SpotifyAPI.Web;
using System.Linq;
using System.Threading.Tasks;

namespace SongInfoTest
{
    
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            // Spotify API
            spotifyClient();
            lblTag.Text = "";
        }

        // Spotify API
        public static async void spotifyClient()
        {
            var config = SpotifyClientConfig.CreateDefault();
            var request = new ClientCredentialsRequest("c0f5291cd00141f095402fd9d85be0e6", "687f4738b74c4ef2b8f4a9e7081b487a");
            var response = await new OAuthClient(config).RequestToken(request);

            clientSpotify = new SpotifyClient(config.WithToken(response.AccessToken));
        }

        // Parent objects
        static LastfmClient clientFM = new LastfmClient("cc9eb261fc35326d97d7492dda22bdf5");
        static SpotifyClient clientSpotify;

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            btnGenerate.Enabled = txtSong.Text != "" && txtArtist.Text != "";
        }

        private async Task<Track> GetTrack(string song, string artist)
        {
            try
            {
                return await clientFM.Track.GetInfoAsync(song, artist);
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
                return track.Album.Images[3].Url;
            }
            catch (Exception e) { return null; }
        }

        private async Task<string> GetTopTag(string song, string artist)
        {
            try
            {
                List<Tag> tags = await clientFM.Track.GetTopTagsAsync(song, artist);
                return tags.First().Name;
            }
            catch (Exception e) { return null; }
        }

        private async Task<string> GetSpotifyLink(string song, string artist)
        {
            try
            {
                SearchRequest searchRequest = new SearchRequest(SearchRequest.Types.Track, $@"%20track:{song}%20artist:{artist}");
                SearchResponse tracks = await clientSpotify.Search.Item(searchRequest);

                return tracks.Tracks.Items.First().ExternalUrls.First().Value;
            }
            catch (Exception e) { return null; }
        }

        private async void DisplaySongInfos(string song, string artist)
        {
            Track track = await GetTrack(song, artist);
            string album = GetAlbum(track);
            string topTag = await GetTopTag(song, artist);
            string spotifyLink = await GetSpotifyLink(song, artist);

            if (track != null) // Only works if the track is found
            {
                lblError.Hide();

                // Display the image on the left of the app
                if (album != null) // Only works if the album cover is found
                {
                    albumDisplayed.ImageLocation = album;
                    lblAlbumNotFound.Visible = false;
                }
                else
                {
                    lblAlbumNotFound.Visible = true;
                    albumDisplayed.ImageLocation = null;
                }

                // Display the song's top genre (last.fm tag)
                if (topTag != null)
                    lblTag.Text = "Song genre: " + topTag;
                else lblTag.Text = "No song genre found";

                // Display the available playbabilities
                if (spotifyLink != null)
                    spotifyLogo.Visible = true;
                else spotifyLogo.Visible = false;

            }
            else lblError.Show();
        }

        private void btnGenerate_ClickAsync(object sender, EventArgs e)
        {
            DisplaySongInfos(txtSong.Text, txtArtist.Text);
        }

        private void llblCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.last.fm/api");
        }

        private async void spotifyLogo_Click(object sender, EventArgs e)
        {
            string link = await GetSpotifyLink(txtSong.Text, txtArtist.Text);
            System.Diagnostics.Process.Start(link);
        }
    }
}
