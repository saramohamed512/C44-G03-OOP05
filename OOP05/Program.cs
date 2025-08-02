using OOP05.Binding;

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
            Employee fullTimeEmp = new FullTimeEmp();
            Employee partTimeEmp = new PartTimeEmp();
            ProcessEmployee(fullTimeEmp); // Calls FullTimeEmp's Fun01 and Fun02
            #endregion
            #endregion
        }
    }
}
