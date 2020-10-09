using BusinessRuleEngine.Products.Interface;
using BusinessRuleEngine.Rules.Interface;
using ProductDataModel;
using System;

namespace BusinessRuleEngine
{
    public class Membership : IProduct
    {
        INotification _notification;
        public Membership(INotification notification)
        {
            _notification = notification;
        }
        public void ProcessOrder(ProductBaseModel productModel=null)
        {
            
            if(productModel is MembershipModel)
            {
                MembershipModel membershipModel = productModel as MembershipModel;
                if (membershipModel.IsUpgrade)
                {
                    Console.WriteLine("Payment recieved to Upgrade Membership");
                    _notification.SendEmail("Email membership upgraded");
                }
                else if(membershipModel.IsActivation)
                {
                    Console.WriteLine("Payment recieved to Activate Membership");
                    _notification.SendEmail("Email membership activated");
                }
            }
           
        }
    }
}
