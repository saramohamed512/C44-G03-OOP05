using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q02
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        private const string ValidUsername = "admin";
        private const string ValidPassword = "123456789";
        private const string ValidRole = "Admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == ValidUsername && password == ValidPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == ValidUsername && role == ValidRole;
        }
    }
}
