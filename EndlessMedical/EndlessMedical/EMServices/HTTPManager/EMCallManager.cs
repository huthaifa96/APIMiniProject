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

        public string SessionID { get; set; }

        public EMCallManager()
        {
            _client = new RestClient(EMConfigReader.BaseUrl);
            SessionID = "iHKXkh6oPzDqxcjb"; //GetSessionID();
            AcceptTnC();
        }

        public string GetSessionID()
        {
            var request = new RestRequest(EMConfigReader.GetSessionID);
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }

        public void AcceptTnC()
        {
            var request = new RestRequest(EMConfigReader.AcceptTnC + EMConfigReader.SessionIDis + SessionID + EMConfigReader.TnCStetmentis + EMConfigReader.TnCStatement) ;
            var response = _client.Execute(request, Method.POST);
        }

        public void AddFeatures(string[] names, string[] values)
        {
            if (names.Length > 0)
            {
                for (int i = 0; i < names.Length-1; i++)
                {
                    var request = new RestRequest(EMConfigReader.UpdateFeatures + EMConfigReader.SessionIDis + SessionID + EMConfigReader.FeatureNameis + names[i] + EMConfigReader.FeatureValueis + values[i]);;
                    var response = _client.Execute(request, Method.POST);
                }
            }
        }

        public string GetResults()
        {
            var request = new RestRequest(EMConfigReader.AnalyzeFeatures + EMConfigReader.SessionIDis + SessionID);
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }


    }
}
