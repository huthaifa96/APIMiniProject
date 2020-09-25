using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessMedical
{
    public class EMDiseasesModel
    {
        public string status { get; set; }
        public JsonArray Diseases { get; set; }
        public JsonArray VariableImportances { get; set; }
        
    }
}
