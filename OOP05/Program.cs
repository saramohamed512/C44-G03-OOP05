using OOP05.Abstraction;
using OOP05.Binding;
using OOP05.BuiltInInterface;
using OOP05.Example01Interface;
using OOP05.Example02Interface;
using OOP05.Interface;
using System.Drawing;
using Type = OOP05.Interface.Type;

namespace OOP05
{
    internal class Program
    {
        #region Binding Usage
        //public static void ProcessEmployee(FullTimeEmp fullEmp)
        //{
        //   if(fullEmp is not null)
        //   {
        //       fullEmp.Fun01(); // Calls FullTimeEmp's Fun01
        //       fullEmp.Fun02(); // Calls FullTimeEmp's Fun02
        //    }
        //}
        //public static void ProcessEmployee(PartTimeEmp partEmp)
        //{
        //    if(partEmp is not null)
        //    {
        //        partEmp.Fun01(); // Calls PartTimeEmp's Fun01
        //        partEmp.Fun02(); // Calls PartTimeEmp's Fun02
        //    }
        //}
        public static void ProcessEmployee(Employee emp)
        {
            if (emp is not null)
            {
                emp.Fun01();
                emp.Fun02(); 
            }
        }
        #endregion
        #region example01 interface
        public  static void SeriesToPrintFiveNums(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Current value in series: {series.Current}");
                    series.GetNextValue();
                }
                series.ResetSeries(); // Calls the default implementation of ResetSeries
            }
            else { return; }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Binding 
            #region example01
            // TypeA type= new TypeB(1, 2);
            // type.A = 10;
            //// type.B= 20;
            // type.Fun01(); // Calls TypeA's Fun01 due to 'new' keyword in TypeB
            // type.Fun02(); // Calls TypeB's Fun02 due to 'override' keyword in TypeB
            #endregion
            #region example02
            //Employee fullTimeEmp = new FullTimeEmp();
            //Employee partTimeEmp = new PartTimeEmp();
            //ProcessEmployee(fullTimeEmp); // Calls FullTimeEmp's Fun01 and Fun02
            #endregion
            #endregion
            #region interface
            //IType refType;
            ////Type type = new Type();//invalid
            ////refType = new Type(); // valid, as Type implements IType
            //refType = new TypeIO(); // valid, as Type implements IType
            //refType.MyProperty = 100;
            //refType.MyMethod(); // Calls MyMethod from TypeIO class
            //refType.Print(); // Calls default Print method from IType interface
            //TypeIO typeIO = new TypeIO();
            //typeIO.MyProperty = 200;
            //typeIO.MyMethod(); // Calls MyMethod from TypeIO class
            ////typeIO.Print(); // invalid, as Print is not defined in TypeIO class
            #region Ex01 
            //SeriesOne s1= new SeriesOne();
            //SeriesToPrintFiveNums(s1); // Prints 5 values in SeriesOne
            #endregion
            #region Ex02
            Car car = new Car();
            //car.Forward(); // Calls Forward method from IMoveOnAir interface
            //car.Backward(); // Calls Backward method from IMoveOnGround interface   
            //car.left(); // Calls left method from IMoveOnAir interface
            //car.Right(); // Calls Right method from IMoveOnGround interface
            AirPlane airPlane = new AirPlane();
            //airPlane.Forward(); // Calls Forward method from IMoveOnAir interface
            //airPlane.Backward(); // Calls Backward method from IMoveOnGround interface
            //airPlane.left(); // Calls left method from IMoveOnAir interface
            //airPlane.Right();
            //IMoveOnAir moveOnAir= new AirPlane();
            //IMoveOnGround moveOnGround = new AirPlane();
            //IMoveOnGround moveOnGround2 = new Car();
            //moveOnGround2.Backward(); // Calls Backward method from IMoveOnGround interface



            #endregion
            #region Built-in Interfaces
            #region ICloneable
            //User user01 = new User() { Id = 1, Name = "John Doe"  ,Salary=1000};
            // User user02 = new User() { Id = 2, Name = "Jane Smith", Salary = 2000 };
            // Console.WriteLine($"user01: {user01.GetHashCode}");
            // Console.WriteLine($"user02: {user02.GetHashCode}");
            // Console.WriteLine($"user01: {user01}"); 
            // Console.WriteLine($"user02: {user02}");
            // Console.WriteLine("Before cloning:");
            // Console.WriteLine("Cloning user01 to user02...");
            // user02 =(User)user01.Clone(); // Cloning user01 to user02
            // Console.WriteLine($"user01: {user01.GetHashCode}");
            // Console.WriteLine($"user02: {user02.GetHashCode}");
            // Console.WriteLine($"user01: {user01}");
            // Console.WriteLine($"user02: {user02}");
            // Console.WriteLine("after cloning:");
            #endregion
            #region IComparable
            //int[] numbers = { 6, 3, 1, 2, 5 , 4};
            User[] users =
            {
                new User() { Id = 1, Name = "Alice", Salary = 3000 },
                new User() { Id = 2, Name = "Bob", Salary = 2000 },
                new User() { Id = 3, Name = "Charlie", Salary = 4000 },
                new User() { Id = 4, Name = "David", Salary = 1000 }
            };
            //Array.Sort(users); // Sorts users based on Salary using CompareTo method
            //Array.Sort(numbers); // Sorts numbers in ascending order
            //foreach (var user in users)
            //{
            //    Console.WriteLine(user); // Prints sorted users
            //}
            #endregion
            #region Icomparer
            //Array.Sort(users, new UserNameComparer()); // Sorts users based on Id using UserComparer
            //foreach (var user in users)
            //{
            //    Console.WriteLine(user); // Prints sorted users
            //}
            #endregion
            #endregion
            #endregion
            #region Abstraction
            //Shape rectangle = new Abstraction.Rectangle() { Dim01 = 5,Dim02=10 };
            //decimal area= rectangle.CalcArea();
            //Console.WriteLine($"Area of Rectangle: {area}");
            //decimal perimeter = rectangle.Perimeter;
            //Console.WriteLine($"Perimeter of Rectangle: {perimeter}");
            //Circle circle = new Circle(5);
            //area = circle.CalcArea();
            //Console.WriteLine($"Area of Circle: {area}");
            //perimeter = circle.Perimeter;
            //Console.WriteLine("Perimeter of Circle: " + perimeter);

            #endregion
        }
    }
}
