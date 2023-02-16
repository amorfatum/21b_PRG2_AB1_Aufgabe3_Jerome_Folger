// See https://aka.ms/new-console-template for more information

using _21b_PRG2_AB1_Aufgabe3_Jerome_Folger;

MessageBroker messageBroker = new MessageBroker();

Email emailA = new Email("jerome.folger@gmail.com", messageBroker);

Email emailB = new Email("max.muster@example.com", messageBroker);

emailA.SendMessage("max.muster@example.com", "Hallo Max Muster, wie geht es ihnen heute?");
//emailA.SendMessage("max.muster@example.com", "Kann ich ihnen eine Frage stellen?");

emailB.RecieveMessage();
emailB.OutputMessage();

emailB.SendMessage("jerome.folger@gmail.com", "Gut, danke dir");

emailA.RecieveMessage();
emailA.OutputMessage();