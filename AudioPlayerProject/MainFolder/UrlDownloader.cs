using System;
using System.Net;
using AngleSharp;

namespace AudioPlayerProject
{
    public class UrlDownloader
    {
        public static bool DownloadStatus { get; set; }

        static string[] simvols = new string[]
        {
            Convert.ToString("#"),
            Convert.ToString("%"),
            Convert.ToString("&"),
            Convert.ToString("{"),
            Convert.ToString("}"),
            Convert.ToString("<"),
            Convert.ToString(">"),
            Convert.ToString("*"),
            Convert.ToString("?"),
            Convert.ToString("/"),
            Convert.ToString("!"),
            Convert.ToString("‘"),
            Convert.ToString("“"),
            Convert.ToString(":"),
            Convert.ToString("@"),
            Convert.ToString("+"),
            Convert.ToString("`"),
            Convert.ToString("|"),
            Convert.ToString(@"\"),
            Convert.ToString('"'),
            Convert.ToString("=")
        };

        public static WebClient webClient { get; private set; } = new WebClient();

        public static void Downloader(string url, string directory, string filename)
        {
            DownloadStatus = true;
            Url urlLink = new Url(url);
            string redact = filename;
            for (int i = 0; i < simvols.Length; i++)
            {
                while (true)
                {
                    if (redact.Contains(simvols[i]))
                    {
                        redact = redact.Remove(redact.IndexOf(simvols[i]),1);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            webClient.DownloadFileAsync(urlLink, directory + redact);
        }
    }
}
