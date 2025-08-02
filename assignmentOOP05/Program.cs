using assignmentOOP05.Q01;
using assignmentOOP05.Q02;
using assignmentOOP05.Q03;

namespace assignmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01

            //IShape circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //IShape rectangle = new Rectangle(4, 6);
            //rectangle.DisplayShapeInfo();

            #endregion
            #region Q02
            //IAuthenticationService authService = new BasicAuthenticationService();
            //bool isAuthenticated = authService.AuthenticateUser("admin", "password123");
            //bool isAuthorized = authService.AuthorizeUser("admin", "Admin");

            //Console.WriteLine($"Authentication: {isAuthenticated}");
            //Console.WriteLine($"Authorization: {isAuthorized}");

            #endregion
            #region Q03
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //string recipient = "user@example.com";
            //string message = "Hello, this is a notification!";

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification("+1234567890", message);
            //pushService.SendNotification("device-id-123", message);
            #endregion

        }
    }
}
