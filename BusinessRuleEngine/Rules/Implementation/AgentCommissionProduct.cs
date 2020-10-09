using BusinessRuleEngine.Rules.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Rules.Implementation
{
    public class AgentCommissionProduct:IAgentCommission
    {
        public void GenerateCommissionPaymentToAgent()
        {
            Console.WriteLine("Generate a commision payment to agent");
        }
    }
}
