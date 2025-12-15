using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public static class Database
    {
        private static readonly string dbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "music.db");

        private static readonly string connectionString =
            $"Data Source={dbPath};Version=3;";


        public static void Initialize()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql = @"

                CREATE TABLE IF NOT EXISTS Songs (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                FilePath TEXT UNIQUE NOT NULL,
                IsFavorite INTEGER NOT NULL DEFAULT 0,
                PlayCount INTEGER NOT NULL DEFAULT 0,
                LastPlayed TEXT
                );


                CREATE TABLE IF NOT EXISTS Videos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FilePath TEXT UNIQUE NOT NULL,
                    IsFavorite INTEGER NOT NULL DEFAULT 0
                );

               CREATE TABLE IF NOT EXISTS Playlists (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT UNIQUE NOT NULL
                );

                CREATE TABLE IF NOT EXISTS PlaylistSongs (
                    PlaylistId INTEGER,
                    SongPath TEXT,
                    PRIMARY KEY (PlaylistId, SongPath)
                );


                ";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Returns an open SQLite connection
        /// </summary>
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}