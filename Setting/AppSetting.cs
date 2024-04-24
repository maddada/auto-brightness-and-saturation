using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_brightness_and_vibrance.Setting
{
    class AppSetting : Settings<AppSetting>
    {
        public double brightness = 0.5;
        public double contrast = 0.5;
        public double gamma = 1.0;
        public int saturation = 0;
        public HashSet<string> pTargets = new HashSet<string>{
            "cs2",
            "cstrike",
            "csgo",
            "EscapeFromTarkov",
        };
        public string display = @"\\.\DISPLAY1";
        public bool minimizeOnStart = false;

        public double prof1Brightness = 0.5;
        public double prof1Contrast = 0.5;
        public double prof1Gamma = 1.0;

        public double prof2Brightness = 0.5;
        public double prof2Contrast = 0.5;
        public double prof2Gamma = 1.0;
    }
}
