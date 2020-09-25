using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessMedical.HTTPManager
{
    public class EMCallManager
    {
        readonly IRestClient _client;

        public EMCallManager()
        {
            _client = new RestClient(EMConfigReader.BaseUrl);
        }

        public string GetSessionID()
        {
            var request = new RestRequest(EMConfigReader.GetSessionID);
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }


    }
}
