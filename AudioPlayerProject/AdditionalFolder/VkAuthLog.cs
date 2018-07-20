namespace AudioPlayerProject
{
    public class VkAuthLog
    {
        public static string GetToken()
        {
            return VKSettings.Default.token;
        }

        public static void SetToken(string str)
        {
            VKSettings.Default.token = str;
        }

        public static bool GetAuth()
        {
            return VKSettings.Default.auth;
        }

        public static void SetAuth(bool bl)
        {
            VKSettings.Default.auth = bl;
        }

        public static string GetId()
        {
            return VKSettings.Default.id;
        }

        public static void SetId(string str)
        {
            VKSettings.Default.id = str;
        }

        public static bool GetSave()
        {
            return VKSettings.Default.saved;
        }

        public static void SetSave(bool bl)
        {
            VKSettings.Default.saved = bl;
        }

        public static void Save()
        {
            VKSettings.Default.Save();
        }
    }
}
