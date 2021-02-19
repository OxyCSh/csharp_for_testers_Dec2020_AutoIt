using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            List<Group> oldGroups = appManager.GroupHelper.GetGroupList();

            Group newGroup = new Group()
            { Name = "grrr" };

            appManager.GroupHelper.AddGroup(newGroup);

            List<Group> newGroups = appManager.GroupHelper.GetGroupList();
            oldGroups.Add(newGroup);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
