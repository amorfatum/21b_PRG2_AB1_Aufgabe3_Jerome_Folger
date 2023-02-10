using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21b_PRG2_AB1_Aufgabe3_Jerome_Folger
{
    internal class Email : IMessage
    {
        public string Message { get; set; }
        public void SendMessage(string message)
        {
            Message = message;
        }

        public string RecieveMessage(string message)
        {
            return Message;
        }

        public void OutputMessage()
        {
            Console.WriteLine(Message);
        }
    }
}
