using BusinessRuleEngine.Products.Interface;
using BusinessRuleEngine.Rules.Interface;
using ProductDataModel;
using System;

namespace BusinessRuleEngine
{
    public class Book : IProduct
    {
        IPackageable _packageable;
        IAgentCommission _agentCommission;
        public Book(IPackageable packageable, IAgentCommission agentCommission)
        {
            _packageable = packageable;
            _agentCommission = agentCommission;
        }
        public void ProcessOrder(ProductBaseModel productModel=null)
        {
            Console.WriteLine("Payment recieved for Book");
            _packageable.GeneratePackagingSlip("Book", 2);
            _agentCommission.GenerateCommissionPaymentToAgent();
        }

    }
}
