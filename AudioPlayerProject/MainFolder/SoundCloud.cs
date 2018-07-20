using System.Collections.Generic;

namespace AudioPlayerProject
{
    public class SoundCloud
    {
        public static bool ListOpened;
        public static string clientID { get; private set; } = "2t9loNQH90kzJcsFCODdigxfp325aq4z";

        public static List<SoundCloud> MyTracklist;
        public static List<SoundCloud> SearchList;

        public int id { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string permalink_url { get; set; }
        public string stream_url { get; set; }
        public string uri { get; set; }
        public bool downloadable { get; set; }
        public string download_url { get; set; }
        public string buferTitle { get; private set; }


        public void CorectArtist()
        {
            if (title.Contains("-"))
            {
                artist = title.Split('-')[0];
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
            else if (title.Contains("—"))
            {
                artist = title.Split('—')[0];
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
        }

        public void CorectTitle()
        {
            buferTitle = title;

            if (buferTitle.Contains("-"))
            {
                title = buferTitle.Split('-')[1];
                while (true && title != "" && title != null)
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

            else if (buferTitle.Contains("—"))
            {
                title = buferTitle.Split('—')[1];
                while (true && buferTitle != "" && buferTitle != null)
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
        }
    }
}
