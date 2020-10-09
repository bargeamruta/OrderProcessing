using ProductDataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Products.Interface
{
    public interface IProduct
    {
        void ProcessOrder(ProductBaseModel productModel=null);
    }
}
