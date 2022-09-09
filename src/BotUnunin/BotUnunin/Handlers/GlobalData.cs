using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotUnunin.Handlers
{
    public class GlobalData
    {
        public static string ConfigPath { get; set; } = "appsettings.json";
        public static BotConfig Config { get; set; }

        public void Initialize()
        {
            var json = File.ReadAllText(ConfigPath, new UTF8Encoding(false));
            Config = JsonConvert.DeserializeObject<BotConfig>(json);
        }

        private static BotConfig GenerateNewConfig() => new BotConfig
        {
            Token = "",
            Prefix = "!",
            GameStatus = "Loving Hoe"
        };
    }
}
