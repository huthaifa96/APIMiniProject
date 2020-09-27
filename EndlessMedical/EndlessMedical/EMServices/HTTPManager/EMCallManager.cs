using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessMedical
{
    public class EMCallManager
    {
        readonly IRestClient _client;

        public JObject Json_SessionID { get; set; }
        public JObject Json_TnC { get; set; }
        public JObject Json_Features { get; set; }

        public EMCallManager()
        {
            _client = new RestClient(EMConfigReader.BaseUrl);
            GetSessionID();
            AcceptTnC();
        }

        public void GetSessionID()
        {
            var request = new RestRequest(EMConfigReader.GetSessionID);
            var response = _client.Execute(request, Method.GET);
            Json_SessionID = JsonConvert.DeserializeObject<JObject>(response.Content);
        }

        public void AcceptTnC()
        {
            var request = new RestRequest(EMConfigReader.AcceptTnC + EMConfigReader.SessionIDis + Json_SessionID["SessionID"] + EMConfigReader.TnCStetmentis + EMConfigReader.TnCStatement) ;
            var response = _client.Execute(request, Method.POST);
            Json_TnC = JsonConvert.DeserializeObject<JObject>(response.Content);
        }

        public void AddFeatures(string[] names, string[] values)
        {
            if (names.Length > 0)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    var request = new RestRequest(EMConfigReader.UpdateFeatures + EMConfigReader.SessionIDis + Json_SessionID["SessionID"] + "&" + EMConfigReader.FeatureNameis + names[i] + "&" + EMConfigReader.FeatureValueis + values[i]);;
                    var response = _client.Execute(request, Method.POST);
                    Json_Features = JsonConvert.DeserializeObject<JObject>(response.Content);
                }
            }
        }

        public string GetResults()
        {
            var request = new RestRequest(EMConfigReader.AnalyzeFeatures + EMConfigReader.SessionIDis + Json_SessionID["SessionID"]);
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }


    }
}
