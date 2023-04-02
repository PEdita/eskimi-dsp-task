using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.EskimiDspPOM
{
    public class LogInClass
    {
        private static string url = "https://dsp.eskimi.com/alogin";

        public static void Open()
        {
            Driver.OpenPage(url);
            string username = "editap87@gmail.com";
            Common.SendKeysToElement("//*[@name='username']", username);
            string password = "$6_M=vt]BTuhHW66";
            Common.SendKeysToElement("//*[@name='password']", password);
            Common.ClickElement("//*[@class='btn-glow primary login span12']");
            Common.WaitForUrlToOpen("https://dsp.eskimi.com/admin?function=campaigns&method=index");
        }
    }
}
