using BusinessRuleEngine.Rules.Interface;
using System;

namespace BusinessRuleEngine.Rules.Implementation
{
    public class NotifiableProduct:INotification
    {
        public void SendEmail(string content)
        {
            Console.WriteLine($"Send Email :{content}");
        }
    }
}
