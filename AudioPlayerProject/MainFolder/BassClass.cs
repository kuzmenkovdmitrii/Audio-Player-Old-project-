using Un4seen.Bass;
using System;
using System.Collections.Generic;

namespace AudioPlayerProject
{
    public class BassClass
    {
        public static int HZ = 44100; // частота дискритизации
        public static bool InitDefaultDevice; //состояние инициализации
        public static int Stream; //канал
        public static int Volume; // громкость;
        public static bool isStoped { get; private set; } = true; // канал остановлен вручную
        public static bool isPaused { get; private set; }
        public static bool EndPlayList; // треклист доигал полностью
        public static bool MuteStatus { get; set; } = false;

        private static readonly List<int> BassPluginsHandles = new List<int>();

        public static bool InitBass(int hz) // инициализация
        {
            if (!InitDefaultDevice)
            {
                InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                if (InitDefaultDevice)
                {
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(TrackBase.AppPath + @"plugins\\bass_aac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(TrackBase.AppPath + @"plugins\\bass_ac3.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(TrackBase.AppPath + @"plugins\\bass_ape.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(TrackBase.AppPath + @"plugins\bass_mpc.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(TrackBase.AppPath + @"plugins\bass_tta.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(TrackBase.AppPath + @"plugins\bassalac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(TrackBase.AppPath + @"plugins\bassflac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(TrackBase.AppPath + @"plugins\bassopus.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(TrackBase.AppPath + @"plugins\basswma.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(TrackBase.AppPath + @"plugins\basswv.dll"));
                }
            }
            return InitDefaultDevice;
        }

        public static void Play(string filename, int vol) //начать воспроизведение трека (из файла)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                isPaused = false;
                if (InitBass(HZ))
                {
                    Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (Stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100f);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
            else
            {
                Bass.BASS_ChannelPlay(Stream, false);
            }
            isStoped = false;
        }

        public static void PlayURL(string url, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                isPaused = false;
                if (InitBass(HZ))
                {
                    Stream = Bass.BASS_StreamCreateURL(url, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);
                    if (Stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100f);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
            else
            {
                Bass.BASS_ChannelPlay(Stream, false);
            }
            isStoped = false;
        }

        public static void Stop() //остановить воспроизведение трека
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            isStoped = true;
            isPaused = false;
        }

        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                isPaused = true;
                Bass.BASS_ChannelPause(Stream);
            }
        }

        public static int GetTimeOfStream(int stream) // получение длительности канала в секундах
        {
            long TimeBites = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBites);
            return (int)Time;
        }

        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            double possec = Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return (int)possec;
        }

        public static void SetVolumeToStream(int stream, int vol) //установить громкость
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100f);
        }

        public static void SetPosOfScroll(int stream, int pos) //установить позицию на трекбаре
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }

        public static bool ToNextTrack()
        {
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStoped))
            {
                if (TrackBase.Files.Count > TrackBase.CurrentTrackNumber + 1)
                {
                    Play(TrackBase.Files[++TrackBase.CurrentTrackNumber], Volume);
                    EndPlayList = false;
                    return true;
                }
                else
                {
                    EndPlayList = true;
                }
            }
            return false;
        }
    }
}
