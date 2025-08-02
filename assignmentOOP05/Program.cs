using assignmentOOP05.Q01;
using assignmentOOP05.Q02;
using assignmentOOP05.Q03;
using assignmentOOP05.Q04;

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
            #region Q04

            Console.WriteLine("Enter your user type (Regular/Premium/Guest):");
            string userTypeInput = Console.ReadLine();


            Console.WriteLine("Enter product price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter product quantity:");
            int quantity = int.Parse(Console.ReadLine());


            User user;
            switch (userTypeInput.ToLower())
            {
                case "regular":
                    user = new RegularUser();
                    break;
                case "premium":
                    user = new PremiumUser();
                    break;
                default:
                    user = new GuestUser();
                    break;
            }


            Discount discount = user.GetDiscount();
            decimal discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0;
            decimal totalPrice = (price * quantity) - discountAmount;

            Console.WriteLine("\n--- Order Summary ---");
            Console.WriteLine($"User Type: {user.Name}");
            Console.WriteLine($"Product Price: {price:C}");
            Console.WriteLine($"Quantity: {quantity}");
            if (discount != null)
            {
                Console.WriteLine($"Discount Applied: {discount.Name}");
                Console.WriteLine($"Discount Amount: {discountAmount:C}");
            }
            else
            {
                Console.WriteLine("No discount applied");
            }
            Console.WriteLine($"Final Price: {totalPrice:C}");
            #endregion


        }
    }
}
