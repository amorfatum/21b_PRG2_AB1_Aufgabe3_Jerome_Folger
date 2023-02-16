using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21b_PRG2_AB1_Aufgabe3_Jerome_Folger
{
    internal class Email : IMessage
    {
        private MessageBroker messageBroker;
        public string emailAdress;
        private string emailMessages;
        public Email(string email, MessageBroker messageBroker)
        {
            this.messageBroker = messageBroker;
            this.emailAdress = email;
        }
        public void SendMessage(string reciever, string message)
        {
            messageBroker.AddMessage(reciever, message);
        }

        public void RecieveMessage()
        {
            this.emailMessages = messageBroker.GetMessages(this.emailAdress);
        }

        public void OutputMessage()
        {
            Console.WriteLine();
            Console.WriteLine(emailMessages);
        }
    }
}
