using assignmentOOP05.Q01;

namespace assignmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
      
            IShape circle = new Circle(5);
            circle.DisplayShapeInfo();

            IShape rectangle = new Rectangle(4, 6);
            rectangle.DisplayShapeInfo();
           
            #endregion
        }
    }
}
