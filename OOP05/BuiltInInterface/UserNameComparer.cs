using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.BuiltInInterface
{
    internal class UserNameComparer : IComparer<User>
    {
        public int Compare(User? x, User? y)
        {
            return string.Compare(x?.Name, y?.Name);
        }
    }
}
