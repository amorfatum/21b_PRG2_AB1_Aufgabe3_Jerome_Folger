using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21b_PRG2_AB1_Aufgabe3_Jerome_Folger
{
    internal class MessageBroker
    {
        private Dictionary<string, string> _messages = new Dictionary<string, string>();
        public void AddMessage(string reciever, string message)
        {
            _messages.Add(reciever, message);
        }

        public string GetMessages(string reciever)
        {
            return _messages[reciever];
        }
    }
}
