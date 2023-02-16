using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21b_PRG2_AB1_Aufgabe3_Jerome_Folger
{
    internal class Sms : IMessage
    {
        public string Message { get; set; }
        public string PhoneNumber { get; set; }
        public void SendMessage(string message, string reciever)
        {
            Message = message;
        }

        public void RecieveMessage()
        {
        }

        public void OutputMessage()
        {
            Console.WriteLine(Message);
        }
    }
}
