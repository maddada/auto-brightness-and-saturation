using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace auto_brightness_and_vibrance.Setting
{
    class GameSetting
    {
        private readonly string settingPath;
        private ColorSetting setting;

        public GameSetting()
        {
            settingPath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Documents\auto-brightness-and-vibrance\local.ini");

            using (StreamReader file = File.OpenText(settingPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                setting = (ColorSetting)serializer.Deserialize(file, typeof(ColorSetting));
            }
            Console.WriteLine(setting);
        }

    }
}
