using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Rules.Interface
{
    public interface INotification
    {
        void SendEmail(string content);
    }
}
