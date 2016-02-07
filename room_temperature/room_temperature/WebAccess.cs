using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace room_temperature
{
    class WebAccess
    {
        static public string Api(string Temperature,string Humidity)
        {
            string url = (string)Properties.Settings.Default["ApiAddress"];
            string resText = "";
            try {
                System.Net.WebClient wc = new System.Net.WebClient();
                System.Collections.Specialized.NameValueCollection ps =
                    new System.Collections.Specialized.NameValueCollection();

                ps.Add("MachineName", (string)Properties.Settings.Default["MachineName"]);
                ps.Add("Temperature", Temperature);
                ps.Add("Humidity", Humidity);

                byte[] ResData = wc.UploadValues(url, ps);
                wc.Dispose();
                resText = System.Text.Encoding.UTF8.GetString(ResData);
                if (resText != "OK")
                {
                    return "APIエラー";
                }
            }
            catch (Exception ex){
                return ex.ToString();
            }

            return null;
        }

    }
}
