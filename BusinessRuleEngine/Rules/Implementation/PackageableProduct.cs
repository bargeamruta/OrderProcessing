using BusinessRuleEngine.Rules.Interface;
using System;

namespace BusinessRuleEngine.Rules.Implementation
{

    public class PackageableProduct : IPackageable
    {
        IPrint _print;
        public PackageableProduct(IPrint print)
        {
            _print = print;
        }
        public void GeneratePackagingSlip(string productName, int noOfCopy = 0)
        {
            int count = 0;
            do
            {
                _print.PrintPackageSlip(productName);
                count++;
            } while (count < noOfCopy);
        }
    }
}
