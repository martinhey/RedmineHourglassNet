﻿using System.IO;
using Newtonsoft.Json;

namespace Develappers.RedmineHourglassApi.Tests
{
    public static class Helpers
    {
        public static Configuration GetTestConfiguration()
        {
            return JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(@"..\..\..\..\config.json"));
        }
    }
}
