using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Example02Interface
{
    internal class AirPlane : Vehicla, IMoveOnAir, IMoveOnGround
    {
        public void Backward()
        {
            Console.WriteLine("Airplane is moving backward");
        }

        public void Forward()
        {
            Console.WriteLine("Airplane is moving forward");
        }

        public void left()
        {
            Console.WriteLine("Airplane is turning left");
        }

        public void Right()
        {
            Console.WriteLine("Airplane is turning right");
        }
        //void IMoveOnGround.Backward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnAir.Backward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnGround.Forward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnAir.Forward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnGround.left()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnAir.left()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnGround.Right()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnAir.Right()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
