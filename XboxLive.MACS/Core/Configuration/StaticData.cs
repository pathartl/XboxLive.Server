﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace XboxLive.MACS.Core.Configuration
{
    public class StaticData
    {
        public ServerOptions ServerOptions;

        public void LoadConfig()
        {
            var files = Directory.EnumerateFiles("config", "server_config.json");

            if (files.Count() == 1)
            {
                var options = JsonConvert.DeserializeObject<ServerOptions>(File.ReadAllText(files.First()));

                ServerOptions = options;
            }
        }
    }
}
