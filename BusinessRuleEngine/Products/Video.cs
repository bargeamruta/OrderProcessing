using BusinessRuleEngine.Products.Interface;
using BusinessRuleEngine.Rules.Interface;
using ProductDataModel;
using System;

namespace BusinessRuleEngine
{
    public class Video : IProduct
    {
        IPackageable _packageable;
        public Video(IPackageable packageable)
        {
            _packageable = packageable;

        }
        public void ProcessOrder(ProductBaseModel productModel=null)
        {
            Console.WriteLine("Payment recieved for Video");

            if (productModel.Name == "Learning to ski")
                _packageable.GeneratePackagingSlip("Learning to Ski Video and First aid");
            else
                _packageable.GeneratePackagingSlip("Video");
        }

    }
}
