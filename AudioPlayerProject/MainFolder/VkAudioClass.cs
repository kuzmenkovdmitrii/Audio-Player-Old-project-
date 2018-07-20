using System.Collections.Generic;

namespace AudioPlayerProject
{
    public class VkAudioClass
    {
        public static bool ListOpened;
        public static List<VkAudioClass> PlayListFiles;
        public static List<VkAudioClass> MyTracklist;
        public static List<VkAudioClass> SearchFiles;
        public static List<VkAudioClass> FavoritesFiles;

        public int aid { get; set; }
        public int owner_id { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public int duration { get; set; }
        public string url { get; set; }
        public string lurlcs_id { get; set; }
        public int genre { get; set; }
    }
}
