using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _21b_PRG2_AB1_Aufgabe3_Jerome_Folger
{
    internal interface IMessage
    {
        string Message { get; set; }

        void SendMessage(string message);

        public string RecieveMessage(string message);

        public void OutputMessage();
    }
}
