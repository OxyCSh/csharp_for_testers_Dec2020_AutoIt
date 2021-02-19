using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class ApplicationManager
    {
        private AutoItX3 autoIt;
        public static string WINTITLE = "Free Address Book";
        private GroupHelper groupHelper;

        public ApplicationManager()
        {
            autoIt = new AutoItX3();
            autoIt.Run(@"C:\Users\oniva\Downloads\FreeAddressBookPortable\AddressBook.exe", "", autoIt.SW_SHOWMAXIMIZED);

            // can be extracted in a method and use when waiting for a window to appear and activate it
            autoIt.WinWait(WINTITLE);
            autoIt.WinActivate(WINTITLE);
            autoIt.WinWaitActive(WINTITLE);

            groupHelper = new GroupHelper(this);
        }

        public AutoItX3 AutoIt
        {
            get { return autoIt; }
        }

        public void Stop()
        {
            autoIt.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d510");
        }

        public GroupHelper GroupHelper
        {
            get { return groupHelper; }
        }
    }
}
