using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace EndlessMedical
{
    class EMConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string GetSessionID = ConfigurationManager.AppSettings["get_sessionID_url_mod"];
        public static readonly string AcceptTnC = ConfigurationManager.AppSettings["accept_terms_and_conditions_url_mod"];
        public static readonly string TnCStetmentis = ConfigurationManager.AppSettings["include_tnc_statement_url_mod"];
        public static readonly string TnCStatement = ConfigurationManager.AppSettings["tnc_acceptance_statement_url_mod"];
        public static readonly string UpdateFeatures = ConfigurationManager.AppSettings["updatefeatures_url_mod"];
        public static readonly string SessionIDis = ConfigurationManager.AppSettings["sessionID_url_mod"];
        public static readonly string FeatureNameis = ConfigurationManager.AppSettings["feature_name_url_mod"];
        public static readonly string FeatureValueis = ConfigurationManager.AppSettings["feature_value_url_mod"];
        public static readonly string AnalyzeFeatures = ConfigurationManager.AppSettings["analyze_url_mod"];
    }
}
