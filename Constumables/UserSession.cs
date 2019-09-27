namespace Consumables
{
    public class UserSession
    {
        public UserSession(string username, char userType)
        {
            Username = username;
            UserType = userType;
        }
        
        public string Username { get; set; }
        public char UserType { get; set; }
    }
}
