using System;
using System.Collections.Generic;

namespace AudioPlayerProject
{
    public static class TrackBase
    {
        public static System.Windows.Forms.OpenFileDialog openFileDialog { get; private set; } = new System.Windows.Forms.OpenFileDialog();

        public static int CurrentTrackNumber;

        public static string AppPath { get; private set; } = AppDomain.CurrentDomain.BaseDirectory; //путь к файлу(не зависимо от того, где он будет храниться)

        public static List<string> Files = new List<string>();

        public static string GetFileName(string file)
        {
            string[] tmp1 = file.Split('\\');
            string track = tmp1[tmp1.Length - 1];
            string[] tmp2 = track.Split('.');
            string fileFormat = tmp2[tmp2.Length - 1];
            track = track.Remove(track.IndexOf("." + fileFormat));
            return track;
        }

        public static string GetFileArtist(string file)
        {
            string[] tmp1 = file.Split('\\');
            string artist;
            if (tmp1[tmp1.Length - 1].Contains("-"))
            {
                artist = tmp1[tmp1.Length - 1].Split('-')[0];
                while (true)
                {
                    if (artist[artist.Length - 1] == ' ')
                    {
                        artist = artist.Remove(artist.Length - 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                artist = tmp1[tmp1.Length - 1];
                artist = RemoveFormat(artist);
            }
            return artist;
        }

        public static string GetFileTitle(string file)
        {
            string[] tmp1 = file.Split('\\');
            string title;
            if (tmp1[tmp1.Length - 1].Contains("-"))
            {
                title = tmp1[tmp1.Length - 1].Split('-')[1];
                title = RemoveFormat(title);
                while (true)
                {
                    if (title[0] == ' ')
                    {
                        title = title.Remove(0, 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                title = "";
            }
            return title;
        }

        private static string RemoveFormat(string str)
        {
            string[] tmp2 = str.Split('.');
            string fileFormat = tmp2[tmp2.Length - 1];
            str = str.Remove(str.IndexOf("." + fileFormat));
            return str;
        }

        public static int GetCollTracks()
        {
            return Files.Count;
        }

        public static string GetInputFormats()
        {
            return
            "Все форматы |*.mp3; *.m4a; *.mp4; *.ogg; *.opus; *.ac3; *.ape; *.mpc; *.flac; *.wma; *.tta; *.alac; *.wv;"
            + "|MPEG Audio Player (*.mp3)|*.mp3"
            + "|Advenced Audio Coding (*.m4a;*.mp4)|*.m4a;*.mp4"
            + "|OGG Vorvis Audio (*.ogg)|*.ogg"
            + "|OPUS Audio (*.opus)|*.opus"
            + "|Dolby Digital AC3 (*.ac3)|*.ac3"
            + "|Monkey's Audio (*.ape)|*.ape"
            + "|MusePack (*.mpc)|*.mpc"
            + "|Free Lossless Audio Codec (*.flac)|*.flac"
            + "|Windows Media Audio (*.wma)|*.wma"
            + "|True Audio (*.tta)|*.tta"
            + "|Apple Lossless Audio Codec (*.alac)|*.alac"
            + "|WavPack (*.wv)|*.wv"
            + "|Waveform Audio File Format (*.wav)|*.wav";
        }
    }
}
