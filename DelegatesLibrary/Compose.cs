using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLibrary
{
    public class Compose
    {

        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Msg { get; set; }
        public string Mode { get; set; }
        public void ComposeMsg(string sender,string receiver,string msg) 
        {

            Sender = sender;
            Receiver = receiver;    
            Msg = msg;          



        }

        public void SendMsgThroWhatsApp(string sender, string receiver, string msg) 
        {

            Mode = "WhatsApp";
        }

        public void SendMsgThroMail(string sender, string receiver, string msg) 
        {
            Mode = Mode + " & Email";
        }

    }
}
