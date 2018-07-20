using System.Collections.Generic;
using Un4seen.Bass.AddOn.Tags;

namespace AudioPlayerProject
{
    public class TagClass
    {
        public int bitRate;
        public int freq;
        public string channels;
        public string artist;
        public string album;
        public string title;
        public string year;

        Dictionary<int, string> channelsDict = new Dictionary<int, string>()
        {
            {0, "null"},
            {1, "mono" },
            {2, "stereo"}
        };

        public TagClass(string file)
        {
            TAG_INFO tagInfo = new TAG_INFO();
            tagInfo = BassTags.BASS_TAG_GetFromFile(file);

            bitRate = tagInfo.bitrate;
            freq = tagInfo.channelinfo.freq;
            channels = channelsDict[tagInfo.channelinfo.chans];
            artist = tagInfo.artist;
            album = tagInfo.album;
            if (tagInfo.title == "" || tagInfo.artist == "")
            {
                artist = TrackBase.GetFileArtist(file);
                title = TrackBase.GetFileTitle(file);
            }
            else
            {
                artist = tagInfo.artist;
                title = tagInfo.title;
            }
            year = tagInfo.year;
        }
    }
}
