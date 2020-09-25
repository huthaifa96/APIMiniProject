using NUnit.Framework;


namespace EndlessMedical
{
    public class EMTests
    {
        private EMService _EMService = new EMService();

        [Test]
        public void CheckSessionIDisGenerated()
        {
            Assert.That(_EMService.EMCallManager.SessionID, Is.EqualTo("iHKXkh6oPzDqxcjb"));
        }

        [Test]
        public void CheckTnCareAgreed()
        {
            Assert.That(_EMService.EMCallManager.SessionID, Is.EqualTo("iHKXkh6oPzDqxcjb"));
        }

        [Test]
        public void AddingFeaturesAndGettingResults()
        {
            string[] names = { "LostOfSmell" };
            string[] value = { "3" };
            _EMService.EMCallManager.AddFeatures(names, value);
            _EMService.GetResults();
            Assert.That(_EMService.EMDataTransferObject.EMDiseasesModel.Diseases[0].ToString(), Is.EqualTo("0.4"));
        }



    }
}
