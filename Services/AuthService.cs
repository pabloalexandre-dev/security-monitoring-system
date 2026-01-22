using SecurityMonitoringSystem.Utils;

namespace SecurityMonitoringSystem.Services
{
    public class AuthService
    {
        public bool Login(string username, string password)
        {
            if (username == "Admin" && password == "123456")
            {
                Logger.Log($"SUCCESS | User: {username}");
                return true;
            }

            Logger.Log($"FAIL | User: {username}");
            return false;
        }
    }
}


      
   



