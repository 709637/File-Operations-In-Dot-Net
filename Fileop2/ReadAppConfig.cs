using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Fileop2
{
    class ReadAppConfig
    {

        public void ReadAppConfigFile()
        {
            //Reading the APP.config-----------------------------------------------------------------------------------------------

            string[] keysFromAppConfig = ConfigurationManager.AppSettings.AllKeys;
            Console.WriteLine(ConfigurationManager.AppSettings[keysFromAppConfig[0]]);

            //Reading the APP.config-----------------------------------------------------------------------------------------------
        }

    }
}
