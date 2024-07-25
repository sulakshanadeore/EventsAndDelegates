namespace DelegatesLibrary
{

    public delegate string GreetUser(string u);
    public delegate void CheckAndShow(string username, string pwd);
    public class Login
    {

        public string Greet(string username)
        {
            return "Welcome to App "+ username;
        }

        public bool Status { get; private set; }

        public void ValidateUser(string username, string password)
        {
            if (username == "Jack" && password == "Jack@123")
            {
                Status = true;
            
            }
            else
            {
                Status = false;
            }

        }

        public void ShowMenu(string username, string password)
        {
            if (Status)
            {
                Console.WriteLine("\n1. Go to Inbox Page \n2. Compose Mail");
            }
        }







    }
}
