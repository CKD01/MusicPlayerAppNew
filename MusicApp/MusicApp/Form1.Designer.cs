using System;
using System.Windows.Forms;

namespace MusicApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlHome = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureHomeCover = new System.Windows.Forms.PictureBox();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.tabLibrary = new System.Windows.Forms.TabPage();
            this.listViewLibrary = new System.Windows.Forms.ListView();
            this.columnHeaderSong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFavorite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddSong = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.tabPlaySongs = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.labelSongTitle = new System.Windows.Forms.Label();
            this.trackBarProgress = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlHome.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHomeCover)).BeginInit();
            this.tabLibrary.SuspendLayout();
            this.tabPlaySongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHome
            // 
            this.tabControlHome.Controls.Add(this.tabMain);
            this.tabControlHome.Controls.Add(this.tabLibrary);
            this.tabControlHome.Controls.Add(this.tabPlaySongs);
            this.tabControlHome.Controls.Add(this.tabSettings);
            this.tabControlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHome.Location = new System.Drawing.Point(0, 0);
            this.tabControlHome.Name = "tabControlHome";
            this.tabControlHome.SelectedIndex = 0;
            this.tabControlHome.Size = new System.Drawing.Size(401, 700);
            this.tabControlHome.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.labelWelcome);
            this.tabMain.Controls.Add(this.pictureHomeCover);
            this.tabMain.Controls.Add(this.labelSubtitle);
            this.tabMain.Location = new System.Drawing.Point(4, 25);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(393, 671);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Home";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.Location = new System.Drawing.Point(50, 50);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(300, 50);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to My Music Player!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureHomeCover
            // 
            this.pictureHomeCover.Image = global::MusicApp.Properties.Resources.musical_note;
            this.pictureHomeCover.InitialImage = null;
            this.pictureHomeCover.Location = new System.Drawing.Point(50, 156);
            this.pictureHomeCover.Name = "pictureHomeCover";
            this.pictureHomeCover.Size = new System.Drawing.Size(300, 300);
            this.pictureHomeCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHomeCover.TabIndex = 1;
            this.pictureHomeCover.TabStop = false;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitle.Location = new System.Drawing.Point(50, 100);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(300, 30);
            this.labelSubtitle.TabIndex = 2;
            this.labelSubtitle.Text = "Enjoy your music collection";
            this.labelSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabLibrary
            // 
            this.tabLibrary.Controls.Add(this.label3);
            this.tabLibrary.Controls.Add(this.listViewLibrary);
            this.tabLibrary.Controls.Add(this.buttonAddSong);
            this.tabLibrary.Controls.Add(this.comboBoxFilter);
            this.tabLibrary.Location = new System.Drawing.Point(4, 25);
            this.tabLibrary.Name = "tabLibrary";
            this.tabLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibrary.Size = new System.Drawing.Size(393, 671);
            this.tabLibrary.TabIndex = 1;
            this.tabLibrary.Text = "Library";
            this.tabLibrary.UseVisualStyleBackColor = true;
            // 
            // listViewLibrary
            // 
            this.listViewLibrary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSong,
            this.columnHeaderFavorite});
            this.listViewLibrary.FullRowSelect = true;
            this.listViewLibrary.GridLines = true;
            this.listViewLibrary.HideSelection = false;
            this.listViewLibrary.Location = new System.Drawing.Point(10, 50);
            this.listViewLibrary.Name = "listViewLibrary";
            this.listViewLibrary.Size = new System.Drawing.Size(380, 500);
            this.listViewLibrary.TabIndex = 0;
            this.listViewLibrary.UseCompatibleStateImageBehavior = false;
            this.listViewLibrary.View = System.Windows.Forms.View.Details;
            this.listViewLibrary.DoubleClick += new System.EventHandler(this.ListViewLibrary_DoubleClick);
            this.listViewLibrary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewLibrary_MouseClick);
            // 
            // columnHeaderSong
            // 
            this.columnHeaderSong.Text = "Song";
            this.columnHeaderSong.Width = 250;
            // 
            // columnHeaderFavorite
            // 
            this.columnHeaderFavorite.Text = "Liked";
            this.columnHeaderFavorite.Width = 250;
            // 
            // buttonAddSong
            // 
            this.buttonAddSong.Location = new System.Drawing.Point(10, 560);
            this.buttonAddSong.Name = "buttonAddSong";
            this.buttonAddSong.Size = new System.Drawing.Size(120, 30);
            this.buttonAddSong.TabIndex = 1;
            this.buttonAddSong.Text = "Add Song";
            this.buttonAddSong.UseVisualStyleBackColor = true;
            this.buttonAddSong.Click += new System.EventHandler(this.ButtonAddSong_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "All",
            "Favorites"});
            this.comboBoxFilter.Location = new System.Drawing.Point(265, 566);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(120, 24);
            this.comboBoxFilter.TabIndex = 2;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilter_SelectedIndexChanged);
            // 
            // tabPlaySongs
            // 
            this.tabPlaySongs.Controls.Add(this.label2);
            this.tabPlaySongs.Controls.Add(this.label1);
            this.tabPlaySongs.Controls.Add(this.pictureBoxCover);
            this.tabPlaySongs.Controls.Add(this.labelSongTitle);
            this.tabPlaySongs.Controls.Add(this.trackBarProgress);
            this.tabPlaySongs.Controls.Add(this.trackBarVolume);
            this.tabPlaySongs.Controls.Add(this.buttonPlay);
            this.tabPlaySongs.Controls.Add(this.buttonPause);
            this.tabPlaySongs.Controls.Add(this.buttonNext);
            this.tabPlaySongs.Controls.Add(this.buttonPrev);
            this.tabPlaySongs.Location = new System.Drawing.Point(4, 25);
            this.tabPlaySongs.Name = "tabPlaySongs";
            this.tabPlaySongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlaySongs.Size = new System.Drawing.Size(393, 671);
            this.tabPlaySongs.TabIndex = 2;
            this.tabPlaySongs.Text = "Now Playing";
            this.tabPlaySongs.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Volume";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Image = global::MusicApp.Properties.Resources.sound_waves;
            this.pictureBoxCover.Location = new System.Drawing.Point(96, 50);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 0;
            this.pictureBoxCover.TabStop = false;
            // 
            // labelSongTitle
            // 
            this.labelSongTitle.Location = new System.Drawing.Point(20, 270);
            this.labelSongTitle.Name = "labelSongTitle";
            this.labelSongTitle.Size = new System.Drawing.Size(350, 30);
            this.labelSongTitle.TabIndex = 1;
            this.labelSongTitle.Text = "Song Title";
            // 
            // trackBarProgress
            // 
            this.trackBarProgress.Location = new System.Drawing.Point(20, 340);
            this.trackBarProgress.Maximum = 100;
            this.trackBarProgress.Name = "trackBarProgress";
            this.trackBarProgress.Size = new System.Drawing.Size(350, 56);
            this.trackBarProgress.TabIndex = 4;
            this.trackBarProgress.Tag = "";
            this.trackBarProgress.Scroll += new System.EventHandler(this.TrackBarProgress_Scroll);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(20, 456);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(350, 56);
            this.trackBarVolume.TabIndex = 5;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.TrackBarVolume_Scroll);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(129, 544);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(50, 50);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = ">";
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(189, 544);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(50, 50);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.Text = "||";
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(249, 544);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(50, 50);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = ">>";
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(69, 544);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(50, 50);
            this.buttonPrev.TabIndex = 9;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.labelTheme);
            this.tabSettings.Controls.Add(this.comboBoxTheme);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(393, 671);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // labelTheme
            // 
            this.labelTheme.Location = new System.Drawing.Point(20, 50);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(100, 25);
            this.labelTheme.TabIndex = 0;
            this.labelTheme.Text = "Theme:";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.comboBoxTheme.Location = new System.Drawing.Point(130, 50);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(150, 24);
            this.comboBoxTheme.TabIndex = 1;
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTheme_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter By:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 700);
            this.Controls.Add(this.tabControlHome);
            this.Name = "Form1";
            this.Text = "Music Player";
            this.tabControlHome.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHomeCover)).EndInit();
            this.tabLibrary.ResumeLayout(false);
            this.tabPlaySongs.ResumeLayout(false);
            this.tabPlaySongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.TabControl tabControlHome;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabLibrary;
        private System.Windows.Forms.TabPage tabPlaySongs;

        // Library
        private System.Windows.Forms.ListView listViewLibrary;
        private System.Windows.Forms.ColumnHeader columnHeaderSong;
        private System.Windows.Forms.ColumnHeader columnHeaderFavorite;
        private System.Windows.Forms.Button buttonAddSong;
        private System.Windows.Forms.ComboBox comboBoxFilter;

        // PlaySongs
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label labelSongTitle;
        private System.Windows.Forms.TrackBar trackBarProgress;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;

        // Settings
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.ComboBox comboBoxTheme;

        // Home
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureHomeCover;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

