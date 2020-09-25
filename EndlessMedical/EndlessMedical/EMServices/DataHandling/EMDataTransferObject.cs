using Newtonsoft.Json;
using System.Web.UI;

namespace EndlessMedical
{
    class EMDataTransferObject
    {
        public EMDiseasesModel EMDiseasesModel { get; set; }

        public void DeserializeResults(string results)
        {
            EMDiseasesModel = JsonConvert.DeserializeObject<EMDiseasesModel>(results);
        }
    }
}
