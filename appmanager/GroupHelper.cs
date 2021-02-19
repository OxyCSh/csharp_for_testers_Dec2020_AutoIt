using System;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    public class GroupHelper : HelperBase
    {
        protected string WINTITLE;
        public static string GROUPWINTITLE = "Group editor";

        public GroupHelper(ApplicationManager appManager) : base (appManager)
        {
            this.WINTITLE = ApplicationManager.WINTITLE;
        }


        private void OpenGroupsDialogue()
        {
            autoIt.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            autoIt.WinWait(GROUPWINTITLE);
        }

        public int NumberOfGroups()
        {
            OpenGroupsDialogue();
            string count = autoIt.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                "GetItemCount", "#0", "");
            CloseGroupsDialogue();

            return int.Parse(count);
        }

        public List<Group> GetGroupList()
        {
            List<Group> list = new List<Group>();

            OpenGroupsDialogue();
            string count = autoIt.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                "GetItemCount", "#0", "");
            for (int i = 0; i < int.Parse(count); i++)
            {
                string groupName = autoIt.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                "GetText", "#0|#"+i, "");
                list.Add(new Group() { Name = groupName });
            }

            CloseGroupsDialogue();
            return list;
        }

        public void AddGroup(Group newGroup)
        {
            OpenGroupsDialogue();
            autoIt.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            autoIt.Send(newGroup.Name);
            autoIt.Send("{ENTER}");
            CloseGroupsDialogue();
        }

        public void RemoveGroup(int index)
        {
            OpenGroupsDialogue();
            autoIt.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                "Select", "#0|#" + index, "");
            autoIt.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d51");
            autoIt.WinWait("Delete group");
            autoIt.ControlClick("Delete group", "", "WindowsForms10.BUTTON.app.0.2c908d53");
            autoIt.WinWait(GROUPWINTITLE);
            CloseGroupsDialogue();
        }

        private void CloseGroupsDialogue()
        {
            autoIt.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d54");
        }

    }
}