using DelegatesLibrary;

public delegate void ComposeAndSend(string sender, string receiver, string msg);
internal class Program
{
    private static void Main(string[] args)
    {
        Login login=new Login();
        CheckAndShow delobj1 = new CheckAndShow(login.ValidateUser);//individual
        CheckAndShow delobj2 = new CheckAndShow(login.ShowMenu);//individual
       CheckAndShow combinedDel=(CheckAndShow)MulticastDelegate.Combine(delobj1,delobj2);//Target of invocation
        combinedDel("Jack", "Jack@123");
        if (login.Status == true)
        {
            Compose obj=new Compose();
            ComposeAndSend[] del = new ComposeAndSend[3] { 
            obj.ComposeMsg,
            obj.SendMsgThroWhatsApp,
            obj.SendMsgThroMail
            
            };
            ComposeAndSend AllTogether=(ComposeAndSend)MulticastDelegate.Combine(del);

            AllTogether("Anil", "Sunil", "Hello");
            Console.WriteLine(obj.Mode);


            //GreetUser greetDel = new GreetUser(login.Greet);
            ////   string msg=greetDel.Invoke("Kamlesh");
            //string msg = greetDel("Jack");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(msg);

        }
        else 
        {
            Console.WriteLine("Check username/password.....");

        }



        Console.ReadLine();
    }
}