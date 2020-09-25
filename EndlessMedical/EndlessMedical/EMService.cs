﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessMedical
{
        
    class EMService
    {
        public EMCallManager EMCallManager { get; set; } = new EMCallManager();

        public string Results { get; set; }

        public JObject Json_Results { get; set; }

        public EMService()
        {                        
        }

        public void GetResults()
        {
            Results = EMCallManager.GetResults();
            Json_Results = JsonConvert.DeserializeObject<JObject>(Results);
        }




    }
}
