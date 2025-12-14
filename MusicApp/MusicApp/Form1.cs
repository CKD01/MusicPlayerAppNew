using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WMPLib;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        private List<string> songs = new List<string>();
        private List<bool> favoriteStatus = new List<bool>();
        private List<string> videos = new List<string>();
        private List<bool> videoFavoriteStatus = new List<bool>();
        private int currentSongIndex = -1;
        private WindowsMediaPlayer player;
        private Timer playbackTimer;
        private string currentVideoPath;

        public Form1()
        {
            InitializeComponent();

            player = new WindowsMediaPlayer();
            playbackTimer = new Timer();
            playbackTimer.Interval = 500;
            playbackTimer.Tick += PlaybackTimer_Tick;

            trackBarVolume.Minimum = 0;
            trackBarVolume.Maximum = 100;
            trackBarVolume.Value = player.settings.volume;

            Database.Initialize();
            LoadSongsFromDatabase();
            LoadVideosFromDatabase();
        }

        private void LoadSongsFromDatabase()
        {
            songs.Clear();
            favoriteStatus.Clear();

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string sql = "SELECT FilePath, IsFavorite FROM Songs";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string path = reader.GetString(0);
                        bool fav = reader.GetInt32(1) == 1;

                        if (File.Exists(path))
                        {
                            songs.Add(path);
                            favoriteStatus.Add(fav);
                        }
                    }
                }
            }

            RefreshLibraryList();
        }

        private void LoadVideosFromDatabase()
        {
            videos.Clear();
            videoFavoriteStatus.Clear();

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string sql = "SELECT FilePath, IsFavorite FROM Videos";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string path = reader.GetString(0);
                        bool fav = reader.GetInt32(1) == 1;

                        if (File.Exists(path))
                        {
                            videos.Add(path);
                            videoFavoriteStatus.Add(fav);
                        }
                    }
                }
            }

            RefreshVideoLibraryList();
        }


        private void RefreshLibraryList()
        {
            // selecting filter (you can choose between "All" and "Favorites")
            string filter = "All";
            if (comboBoxFilter.SelectedItem != null)
            {
                filter = comboBoxFilter.SelectedItem.ToString();
            }

            listViewLibrary.Items.Clear();
            for (int i = 0; i < songs.Count; i++)
            {
                bool isFavorite = favoriteStatus[i];

                if (filter == "Favorites" && !isFavorite)
                {
                    continue;
                }

                string fileName = Path.GetFileName(songs[i]);
                ListViewItem item = new ListViewItem(fileName);

                if (isFavorite)
                {
                    item.SubItems.Add("Liked");
                }
                else
                {
                    item.SubItems.Add("");
                }

                listViewLibrary.Items.Add(item);
            }
        }

        private void PlaySong(int index)
        {
            if (index < 0 || index >= songs.Count)
            {
                return;
            }

            string songPath = songs[index];
            player.URL = songPath;
            player.controls.play();

            string songName = Path.GetFileName(songPath);
            labelSongTitle.Text = songName;
            currentSongIndex = index;
            playbackTimer.Start();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (currentSongIndex >= 0)
            {
                player.controls.play();
            }
            else if (songs.Count > 0)
            {
                currentSongIndex = 0;
                PlaySong(currentSongIndex);
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        // Not implmented yet
        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            playbackTimer.Stop();
            trackBarProgress.Value = 0;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int nextIndex = currentSongIndex + 1;
            if (nextIndex < songs.Count)
            {
                PlaySong(nextIndex);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            int prevIndex = currentSongIndex - 1;

            if (prevIndex >= 0)
            {
                PlaySong(prevIndex);
            }
        }

        private void PlaybackTimer_Tick(object sender, EventArgs e)
        {
            if (player.currentMedia != null)
            {
                double duration = player.currentMedia.duration;
                double current = player.controls.currentPosition;

                trackBarProgress.Maximum = (int)duration;
                trackBarProgress.Value = (int)current;
            }
        }

        private void TrackBarVolume_Scroll(object sender, EventArgs e)
        {
            int volume = trackBarVolume.Value;
            player.settings.volume = volume;
        }

        private void TrackBarProgress_Scroll(object sender, EventArgs e)
        {
            if (player.currentMedia != null)
            {
                int position = trackBarProgress.Value;
                player.controls.currentPosition = position;
            }
        }

        private void ComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLibraryList();
        }

        private void ListViewLibrary_DoubleClick(object sender, EventArgs e)
        {
            if (listViewLibrary.SelectedIndices.Count > 0)
            {
                int index = listViewLibrary.SelectedIndices[0];
                currentSongIndex = index;
                PlaySong(currentSongIndex);
                tabControlHome.SelectedTab = tabPlaySongs;
            }
        }

        private void ListViewLibrary_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && listViewLibrary.SelectedIndices.Count > 0)
            {
                int index = listViewLibrary.SelectedIndices[0];

                favoriteStatus[index] = !favoriteStatus[index];
                bool isFav = favoriteStatus[index];

                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = "UPDATE Songs SET IsFavorite=@fav WHERE FilePath=@path";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@fav", isFav ? 1 : 0);
                        cmd.Parameters.AddWithValue("@path", songs[index]);
                        cmd.ExecuteNonQuery();
                    }
                }

                RefreshLibraryList();
            }
        }

        private void ButtonAddSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Audio Files|*.mp3;*.wav";
            openDialog.Multiselect = true;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    foreach (string file in openDialog.FileNames)
                    {
                        if (!songs.Contains(file))
                        {
                            songs.Add(file);
                            favoriteStatus.Add(false);

                            string sql =
                                "INSERT OR IGNORE INTO Songs (FilePath, IsFavorite) VALUES (@path, 0)";

                            using (var cmd = new SQLiteCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@path", file);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                RefreshLibraryList();
            }
        }




        // Changin theme between Dark and Light
        private void ComboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTheme.SelectedItem != null)
            {
                string theme = comboBoxTheme.SelectedItem.ToString();

                if (theme == "Dark")
                {
                    this.BackColor = Color.FromArgb(30, 30, 30);
                    SetControlsTheme(this.Controls, Color.White, Color.FromArgb(30, 30, 30));
                }
                else
                {
                    this.BackColor = SystemColors.Control;
                    SetControlsTheme(this.Controls, Color.Black, SystemColors.Control);
                }
            }
        }

        private void SetControlsTheme(Control.ControlCollection controls, Color foreColor, Color backColor)
        {
            foreach (Control ctrl in controls)
            {
                ctrl.ForeColor = foreColor;
                ctrl.BackColor = backColor;

                if (ctrl.HasChildren)
                {
                    SetControlsTheme(ctrl.Controls, foreColor, backColor);
                }
            }
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("language", "en");
                    Application.Restart();
                    break;
                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
                case 2:
                    changeLanguage.UpdateConfig("language", "es");
                    Application.Restart();
                    break;

                default:
                    changeLanguage.UpdateConfig("language", "en");
                    break;
            }
        }

        private void buttonNext_MouseDown(object sender, MouseEventArgs e)
        {
            player.settings.rate = 1.4;
        }

        private void buttonNext_MouseUp(object sender, MouseEventArgs e)
        {
            player.settings.rate = 1.0;
        }

        private void buttonNext_MouseLeave(object sender, EventArgs e)
        {
            player.settings.rate = 1.0;
        }

        private void buttonAddVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mov";
            openDialog.Multiselect = true;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    foreach (string file in openDialog.FileNames)
                    {
                        if (!videos.Contains(file))
                        {
                            videos.Add(file);
                            videoFavoriteStatus.Add(false);

                            string sql =
                                "INSERT OR IGNORE INTO Videos (FilePath, IsFavorite) VALUES (@path, 0)";

                            using (var cmd = new SQLiteCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@path", file);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                RefreshVideoLibraryList();
            }
        }

        private void RefreshVideoLibraryList()
        {
            // Selecting filter ("All" or "Favorites")
            string filter = "All";
            if (comboBoxVideoFilter.SelectedItem != null)
            {
                filter = comboBoxVideoFilter.SelectedItem.ToString();
            }

            listViewVideoLibrary.Items.Clear();

            for (int i = 0; i < videos.Count; i++)
            {
                bool isFavorite = videoFavoriteStatus[i];

                if (filter == "Favorites" && !isFavorite)
                    continue;

                string filePath = videos[i];
                ListViewItem item = new ListViewItem(filePath);

                if (isFavorite)
                    item.SubItems.Add("Liked");
                else
                    item.SubItems.Add("");

                listViewVideoLibrary.Items.Add(item);
            }
        }

        private async void listViewVideoLibrary_DoubleClick(object sender, EventArgs e)
        {
            if (listViewVideoLibrary.SelectedItems.Count == 0)
                return;

            currentVideoPath = listViewVideoLibrary.SelectedItems[0].Text;
            MessageBox.Show($"{currentVideoPath}");

            tabControlHome.SelectedTab = tabNowPlayingVideo;

            await webViewVideo.EnsureCoreWebView2Async();

            webViewVideo.Source = new Uri(currentVideoPath);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string query = textBoxSearch.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(query))
            {
                listBoxSearchResults.Visible = false;
                listBoxSearchResults.Items.Clear();
                return;
            }

            listBoxSearchResults.Items.Clear();
            listBoxSearchResults.Visible = true;

            for (int i = 0; i < songs.Count; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(songs[i]).ToLower();

                if (fileName.Contains(query))
                {
                    listBoxSearchResults.Items.Add(new SearchResult
                    {
                        Index = i,
                        Display = Path.GetFileNameWithoutExtension(songs[i])
                    });
                }
            }
        }

        private void listBoxSearchResults_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxSearchResults.SelectedItem is SearchResult result)
            {
                PlaySong(result.Index);
                tabControlHome.SelectedTab = tabPlaySongs;

                listBoxSearchResults.Visible = false;
                textBoxSearch.Clear();
            }
        }

        private void buttonNewPlaylist_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter playlist name:", "New Playlist");

            if (string.IsNullOrWhiteSpace(name))
                return;

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string sql = "INSERT OR IGNORE INTO Playlists (Name) VALUES (@name)";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadPlaylists();
        }

        private void LoadPlaylists()
        {
            listBoxPlaylists.Items.Clear();

            // playlists already created
            listBoxPlaylists.Items.Add("⭐ Favorites");
            listBoxPlaylists.Items.Add("🕒 Recently Played");
            listBoxPlaylists.Items.Add("🔥 Most Played");

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string sql = "SELECT Name FROM Playlists";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxPlaylists.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void listBoxPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlaylists.SelectedItem == null) return;

            string selected = listBoxPlaylists.SelectedItem.ToString();

            if (selected.StartsWith("⭐"))
            {
                ShowFavoriteSongs();
            }
            else
            {
                ShowCustomPlaylist(selected);
            }
        }

        private void ShowFavoriteSongs()
        {
            listViewPlaylistSongs.Items.Clear();

            for (int i = 0; i < songs.Count; i++)
            {
                if (favoriteStatus[i])
                {
                    listViewPlaylistSongs.Items.Add(
                        Path.GetFileNameWithoutExtension(songs[i]));
                }
            }
        }

        private void ShowCustomPlaylist(string playlistName)
        {
            listViewPlaylistSongs.Items.Clear();

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string sql = @"
        SELECT SongPath FROM PlaylistSongs
        WHERE PlaylistId = (
            SELECT Id FROM Playlists WHERE Name = @name
        )";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", playlistName);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string path = reader.GetString(0);
                            listViewPlaylistSongs.Items.Add(
                                Path.GetFileNameWithoutExtension(path));
                        }
                    }
                }
            }
        }

        private void AddSongToPlaylist(string songPath, string playlistName)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string sql = @"
        INSERT OR IGNORE INTO PlaylistSongs (PlaylistId, SongPath)
        VALUES (
            (SELECT Id FROM Playlists WHERE Name = @name),
            @path
        )";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", playlistName);
                    cmd.Parameters.AddWithValue("@path", songPath);
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
