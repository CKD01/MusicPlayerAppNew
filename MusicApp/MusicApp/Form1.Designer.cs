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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlHome = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureHomeCover = new System.Windows.Forms.PictureBox();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.tabLibrary = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewLibrary = new System.Windows.Forms.ListView();
            this.columnHeaderSong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFavorite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddSong = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.tabPlaySongs = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSongTitle = new System.Windows.Forms.Label();
            this.trackBarProgress = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.tabControlHome.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHomeCover)).BeginInit();
            this.tabLibrary.SuspendLayout();
            this.tabPlaySongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHome
            // 
            this.tabControlHome.Controls.Add(this.tabMain);
            this.tabControlHome.Controls.Add(this.tabLibrary);
            this.tabControlHome.Controls.Add(this.tabPlaySongs);
            this.tabControlHome.Controls.Add(this.tabSettings);
            resources.ApplyResources(this.tabControlHome, "tabControlHome");
            this.tabControlHome.Name = "tabControlHome";
            this.tabControlHome.SelectedIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.labelWelcome);
            this.tabMain.Controls.Add(this.pictureHomeCover);
            this.tabMain.Controls.Add(this.labelSubtitle);
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Name = "tabMain";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            resources.ApplyResources(this.labelWelcome, "labelWelcome");
            this.labelWelcome.Name = "labelWelcome";
            // 
            // pictureHomeCover
            // 
            this.pictureHomeCover.Image = global::MusicApp.Properties.Resources.musical_note;
            resources.ApplyResources(this.pictureHomeCover, "pictureHomeCover");
            this.pictureHomeCover.Name = "pictureHomeCover";
            this.pictureHomeCover.TabStop = false;
            // 
            // labelSubtitle
            // 
            resources.ApplyResources(this.labelSubtitle, "labelSubtitle");
            this.labelSubtitle.Name = "labelSubtitle";
            // 
            // tabLibrary
            // 
            this.tabLibrary.Controls.Add(this.label3);
            this.tabLibrary.Controls.Add(this.listViewLibrary);
            this.tabLibrary.Controls.Add(this.buttonAddSong);
            this.tabLibrary.Controls.Add(this.comboBoxFilter);
            resources.ApplyResources(this.tabLibrary, "tabLibrary");
            this.tabLibrary.Name = "tabLibrary";
            this.tabLibrary.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // listViewLibrary
            // 
            this.listViewLibrary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSong,
            this.columnHeaderFavorite});
            this.listViewLibrary.FullRowSelect = true;
            this.listViewLibrary.GridLines = true;
            this.listViewLibrary.HideSelection = false;
            resources.ApplyResources(this.listViewLibrary, "listViewLibrary");
            this.listViewLibrary.Name = "listViewLibrary";
            this.listViewLibrary.UseCompatibleStateImageBehavior = false;
            this.listViewLibrary.View = System.Windows.Forms.View.Details;
            this.listViewLibrary.DoubleClick += new System.EventHandler(this.ListViewLibrary_DoubleClick);
            this.listViewLibrary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewLibrary_MouseClick);
            // 
            // columnHeaderSong
            // 
            resources.ApplyResources(this.columnHeaderSong, "columnHeaderSong");
            // 
            // columnHeaderFavorite
            // 
            resources.ApplyResources(this.columnHeaderFavorite, "columnHeaderFavorite");
            // 
            // buttonAddSong
            // 
            resources.ApplyResources(this.buttonAddSong, "buttonAddSong");
            this.buttonAddSong.Name = "buttonAddSong";
            this.buttonAddSong.UseVisualStyleBackColor = true;
            this.buttonAddSong.Click += new System.EventHandler(this.ButtonAddSong_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.Items.AddRange(new object[] {
            resources.GetString("comboBoxFilter.Items"),
            resources.GetString("comboBoxFilter.Items1")});
            resources.ApplyResources(this.comboBoxFilter, "comboBoxFilter");
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilter_SelectedIndexChanged);
            // 
            // tabPlaySongs
            // 
            this.tabPlaySongs.Controls.Add(this.label2);
            this.tabPlaySongs.Controls.Add(this.label1);
            this.tabPlaySongs.Controls.Add(this.labelSongTitle);
            this.tabPlaySongs.Controls.Add(this.trackBarProgress);
            this.tabPlaySongs.Controls.Add(this.trackBarVolume);
            this.tabPlaySongs.Controls.Add(this.buttonPlay);
            this.tabPlaySongs.Controls.Add(this.buttonPause);
            this.tabPlaySongs.Controls.Add(this.buttonNext);
            this.tabPlaySongs.Controls.Add(this.buttonPrev);
            this.tabPlaySongs.Controls.Add(this.pictureBoxCover);
            resources.ApplyResources(this.tabPlaySongs, "tabPlaySongs");
            this.tabPlaySongs.Name = "tabPlaySongs";
            this.tabPlaySongs.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelSongTitle
            // 
            resources.ApplyResources(this.labelSongTitle, "labelSongTitle");
            this.labelSongTitle.Name = "labelSongTitle";
            // 
            // trackBarProgress
            // 
            resources.ApplyResources(this.trackBarProgress, "trackBarProgress");
            this.trackBarProgress.Maximum = 100;
            this.trackBarProgress.Name = "trackBarProgress";
            this.trackBarProgress.Tag = "";
            this.trackBarProgress.Scroll += new System.EventHandler(this.TrackBarProgress_Scroll);
            // 
            // trackBarVolume
            // 
            resources.ApplyResources(this.trackBarVolume, "trackBarVolume");
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.TrackBarVolume_Scroll);
            // 
            // buttonPlay
            // 
            resources.ApplyResources(this.buttonPlay, "buttonPlay");
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            resources.ApplyResources(this.buttonPause, "buttonPause");
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonNext
            // 
            resources.ApplyResources(this.buttonNext, "buttonNext");
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            resources.ApplyResources(this.buttonPrev, "buttonPrev");
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Image = global::MusicApp.Properties.Resources.sound_waves;
            resources.ApplyResources(this.pictureBoxCover, "pictureBoxCover");
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.TabStop = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.languageComboBox);
            this.tabSettings.Controls.Add(this.languageLabel);
            this.tabSettings.Controls.Add(this.labelTheme);
            this.tabSettings.Controls.Add(this.comboBoxTheme);
            resources.ApplyResources(this.tabSettings, "tabSettings");
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // labelTheme
            // 
            resources.ApplyResources(this.labelTheme, "labelTheme");
            this.labelTheme.Name = "labelTheme";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.Items.AddRange(new object[] {
            resources.GetString("comboBoxTheme.Items"),
            resources.GetString("comboBoxTheme.Items1")});
            resources.ApplyResources(this.comboBoxTheme, "comboBoxTheme");
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTheme_SelectedIndexChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlHome);
            this.Name = "Form1";
            this.tabControlHome.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHomeCover)).EndInit();
            this.tabLibrary.ResumeLayout(false);
            this.tabPlaySongs.ResumeLayout(false);
            this.tabPlaySongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
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
        private ComboBox languageComboBox;
        private Label languageLabel;
    }
}

