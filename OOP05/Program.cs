using OOP05.Binding;

namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binding 
           // TypeA type= new TypeB(1, 2);
           // type.A = 10;
           //// type.B= 20;
           // type.Fun01(); // Calls TypeA's Fun01 due to 'new' keyword in TypeB
           // type.Fun02(); // Calls TypeB's Fun02 due to 'override' keyword in TypeB
            #endregion
        }
    }
}
