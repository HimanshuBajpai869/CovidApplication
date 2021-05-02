﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidLibrary.Models
{
    public class DistrictDetails
    {
        [JsonProperty("districts")]
        public District[] Districts { get; set; }
    }
}
