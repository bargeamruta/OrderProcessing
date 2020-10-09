using BusinessRuleEngine;
using BusinessRuleEngine.Logic;
using BusinessRuleEngine.Products.Interface;
using ProductDataModel;
using System;

namespace OrderProcessing
{
    class Program
    {
        static IProduct product;
        static void Main(string[] args)
        {
            string repeat;
            
            do
            {
                string input;  string subInput;
                DisplayClientUI(out input,out subInput);
                ProductBaseModel model=ProcessUserInput(input, subInput);
                product?.ProcessOrder(model);
                Console.WriteLine("If you want to repeat, press Y");
                repeat = Console.ReadLine();
            } while (repeat.ToLower().Equals("y"));
        }

        private static void DisplayClientUI(out string input,out string subInput)
        {
            Console.WriteLine("Payment done for?");
            Console.WriteLine("1. Physical Product");
            Console.WriteLine("2. Book");
            Console.WriteLine("3. Video");
            Console.WriteLine("4. Membership");
            input = Console.ReadLine();
            
            subInput = string.Empty;
            if (input == "3")
            {
                Console.WriteLine("a. Other Videos");
                Console.WriteLine("b. Learning to Ski");
                subInput = Console.ReadLine();
            }
            if (input == "4")
            {
                Console.WriteLine("a. Activate Membership");
                Console.WriteLine("b. Upgrade Membership");
                subInput = Console.ReadLine();
            }
        }
        private static ProductBaseModel ProcessUserInput(string input, string subInput)
        {
            product = OrderedProduct.CreateOrderedProduct(input);
            switch (input + subInput)
            {
                case "4a":
                    return new MembershipModel() { IsActivation = true };
                case "4b":
                    return new MembershipModel() { IsUpgrade = true };
                case "3b":
                    return new VideoModel() { Name = "Learning to Ski" };
                default:
                    return null;
            }
        }
    }
}
