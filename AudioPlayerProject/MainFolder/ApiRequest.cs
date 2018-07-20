using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Linq;

namespace AudioPlayerProject
{
    public class ApiRequest
    {
        public static string GetRequest(string url, string type)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader nameReader = new StreamReader(stream);
            string responseFromServer = nameReader.ReadToEnd();
            stream.Close();
            response.Close();
            responseFromServer = HttpUtility.HtmlDecode(responseFromServer);

            JToken tokenname = JToken.Parse(responseFromServer);
            string outRequest = tokenname["response"][type].ToString();
            return outRequest;
        }

        public static List<VkAudioClass> GetTracklistVK(string url)
        {
            List<VkAudioClass> audiolist;
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            responseFromServer = HttpUtility.HtmlDecode(responseFromServer);

            JToken token = JToken.Parse(responseFromServer);
            audiolist = token["response"].Children().Skip(1).Select(c => c.ToObject<VkAudioClass>()).ToList();

            return audiolist;
        }

        public static List<SoundCloud> GetTracklistSoundcloud(string url)
        {
            List<SoundCloud> audiolist;
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            responseFromServer = HttpUtility.HtmlDecode(responseFromServer);

            JToken token = JToken.Parse(responseFromServer);
            audiolist = token.Children().Skip(1).Select(c => c.ToObject<SoundCloud>()).ToList();

            return audiolist;
        }
    }
}
