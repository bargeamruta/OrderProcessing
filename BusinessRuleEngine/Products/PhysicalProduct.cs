using BusinessRuleEngine.Products.Interface;
using BusinessRuleEngine.Rules.Interface;
using ProductDataModel;
using System;

namespace BusinessRuleEngine
{
    public class PhysicalProduct : IProduct
    {
        IPackageable _packageable;
        IAgentCommission _agentCommission;
        public PhysicalProduct(IPackageable packageable, IAgentCommission agentCommission)
        {
            _packageable = packageable;
            _agentCommission = agentCommission;
        }
        public void ProcessOrder(ProductBaseModel productModel=null)
        {
            Console.WriteLine("Payment recieved for Physical Product");
            _packageable.GeneratePackagingSlip("Physical Product");
            _agentCommission.GenerateCommissionPaymentToAgent();
        }

    }
}
