using NUnit.Framework;


namespace EndlessMedical
{
    public class EMTests
    {
        private EMService _EMService = new EMService();

        [Test]
        public void CheckStatusIs200()
        {
            Assert.That(_EMService.SessionID != null);
        }


    }
}
