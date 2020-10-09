using BusinessRuleEngine.Helpers;
using BusinessRuleEngine.Products.Interface;


namespace BusinessRuleEngine.Logic
{
    public class OrderedProduct
    {
        
        public static IProduct CreateOrderedProduct(string input)
        {
            switch (input)
            {
                case "1":
                    return new DependencyResolver<PhysicalProduct>().CreateProductInstance();
                case "2":
                    return new DependencyResolver<Book>().CreateProductInstance();
                case "3":
                    return new DependencyResolver<Video>().CreateProductInstance();
                case "4":
                    return new DependencyResolver<Membership>().CreateProductInstance();
                default:
                    return null;
            }
        }

    }
}
