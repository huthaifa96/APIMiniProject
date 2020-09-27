using NUnit.Framework;
using System.Linq;

namespace EndlessMedical
{
    public class EMTests
    {
        private EMService _EMService = new EMService();

        [Test]
        public void CheckSessionIDisGenerated()
        {
            Assert.That(_EMService.EMCallManager.Json_SessionID["status"].ToString(), Is.EqualTo("ok"));
        }

        [Test]
        public void CheckTnCareAgreed()
        {
            Assert.That(_EMService.EMCallManager.Json_TnC["status"].ToString(), Is.EqualTo("ok"));
        }

        [Test]
        public void CheckResultsReturn()
        {
            _EMService.GetResults();
            Assert.That(_EMService.Json_Results["status"].ToString(), Is.EqualTo("ok"));
        }

        [Test]
        public void TestingAddFeaturesMethod()
        {
            string[] names = { "LostOfSmell" };
            string[] value = { "3" };
            _EMService.EMCallManager.AddFeatures(names, value);
            _EMService.GetResults();
            Assert.That(_EMService.EMCallManager.Json_Features["status"].ToString(), Is.EqualTo("ok"));
        }

        [Test]
        public void AddingFeaturesAndGettingResults()
        {
            string[] names = { "Age" };
            string[] value = { "119" };
            _EMService.EMCallManager.AddFeatures(names, value);
            _EMService.GetResults();
            Assert.That(_EMService.EMDataTransferObject.EMDiseasesModelTwo.Diseases[0].ToString, Is.EqualTo("{\r\n  \"Irritable bowel syndrome\": \"0.4125\"\r\n}"));
        }

        [Test]
        public void AddingMultipleFeaturesAndGettingResults()
        {
            string[] names = { "Chills" , "LostOfSmell", "HistoryFever", "ChokingSwallow", "GeneralizedWeakness", "SoreThroatROS" };
            string[] value = { "3", "3", "3", "3", "3", "4"};
            _EMService.EMCallManager.AddFeatures(names, value);
            _EMService.GetResults();
            Assert.That(_EMService.EMDataTransferObject.EMDiseasesModelTwo.Diseases[0].ToString, Is.EqualTo("{\r\n  \"Viral pharyngitis (etiology usually rhinovirus, coronavirus, adenovirus, parainfluenza)\": \"0.778125\"\r\n}"));
        }


    }
}
