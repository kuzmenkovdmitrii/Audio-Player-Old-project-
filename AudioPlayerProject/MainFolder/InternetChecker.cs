using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace AudioPlayerProject
{
    public class InternetChecker
    {
        public static bool ConnectionAvailable(string strServer)
        {
            try
            {
                HttpWebRequest reqFP = (HttpWebRequest)HttpWebRequest.Create(strServer);
  
                HttpWebResponse rspFP = (HttpWebResponse)reqFP.GetResponse();
                if (HttpStatusCode.OK == rspFP.StatusCode) //интернет есть
                {
                    rspFP.Close();
                    return true;
                }
                else // интернета нету 
                {
                    rspFP.Close();
                    return false;
                }
            }
            catch (WebException) // интернета нету
            {
                return false;
            }
        }
    }
}
