using NUnit.Framework;

namespace addressbook_tests_autoit
{
    public class TestBase
    {
        public ApplicationManager appManager;

        [OneTimeSetUp]
        public void InitApplication()
        {
            appManager = new ApplicationManager();
        }

        [OneTimeTearDown]
        public void StopApplication()
        {
            appManager.Stop();
        }
    }
}
