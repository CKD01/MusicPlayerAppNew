using System;
using System.Collections.Generic;
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
        private int currentSongIndex = -1;
        private WindowsMediaPlayer player;
        private Timer playbackTimer;

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
                bool currentFav = favoriteStatus[index];
                favoriteStatus[index] = !currentFav;
                RefreshLibraryList();
            }
        }

        private void ButtonAddSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Audio Files|*.mp3;*.wav";
            openDialog.Multiselect = true;

            DialogResult result = openDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] files = openDialog.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    songs.Add(files[i]);
                    favoriteStatus.Add(false);
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
    }
}
