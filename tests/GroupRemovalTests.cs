using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            if (appManager.GroupHelper.NumberOfGroups() < 2)
            {
                Group group = new Group() { Name = "test group" };
                appManager.GroupHelper.AddGroup(group);
            }

            List<Group> oldGroups = appManager.GroupHelper.GetGroupList();

            int groupToBeRemovedIndex = 0;

            Group toBeRemoved = oldGroups[groupToBeRemovedIndex];

            appManager.GroupHelper.RemoveGroup(groupToBeRemovedIndex);

            List<Group> newGroups = appManager.GroupHelper.GetGroupList();

            oldGroups.RemoveAt(groupToBeRemovedIndex);

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
