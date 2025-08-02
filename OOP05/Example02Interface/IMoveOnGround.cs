using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Example02Interface
{
    internal interface IMoveOnGround
    {
        public void Forward();
      public void Backward();
        public void left();
        public void Right();
    }
}
