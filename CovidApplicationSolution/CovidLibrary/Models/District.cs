﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidLibrary.Models
{
    public class District
    {
        [JsonProperty("district_id")]
        public string DistrictID { get; set; }

        [JsonProperty("district_name")]
        public string DistrictName { get; set; }
    }
}
