using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class HelperBase
    {
        protected ApplicationManager appManager;
        protected AutoItX3 autoIt;

        public HelperBase(ApplicationManager appManager)
        {
            this.appManager = appManager;
            this.autoIt = appManager.AutoIt;
        }
    }
}