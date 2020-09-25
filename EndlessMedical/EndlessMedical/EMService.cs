using Newtonsoft.Json;
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
        public EMDataTransferObject EMDataTransferObject { get; set; } = new EMDataTransferObject();
        public string Results { get; set; }
        public string MostLikelyDisease { get; set; }
        public JObject Json_Results { get; set; }

        public EMService()
        {                        
        }

        public void GetResults()
        {
            Results = EMCallManager.GetResults();
            EMDataTransferObject.DeserializeResults(Results);
            Json_Results = JsonConvert.DeserializeObject<JObject>(Results);
            MostLikelyDisease = Json_Results["Diseases"][0].ToString();
        }




    }
}
