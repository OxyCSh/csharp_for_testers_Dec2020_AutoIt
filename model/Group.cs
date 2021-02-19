using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_tests_autoit
{
    public class Group : IComparable<Group>, IEquatable<Group>
    {
        public string Name { get; set; }

        public int CompareTo(Group other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public bool Equals(Group other)
        {
            return this.Name.Equals(other.Name);
        }
    }
}
