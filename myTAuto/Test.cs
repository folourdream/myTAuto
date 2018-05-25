using NUnit.Framework;
using myTAuto;



namespace myTAuto
{
    [SetUpFixture]
    public class TestSetup
    {

        [OneTimeSetUp]
        public void Start()
        {
            TestBase.BeginExecution();
        }

        [OneTimeTearDown]
        public void End()
        {
            TestBase.ExitExecution();
        }
    }
}