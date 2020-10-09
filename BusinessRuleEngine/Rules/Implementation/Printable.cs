using BusinessRuleEngine.Rules.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Rules.Implementation
{
    public class Printable:IPrint
    {
        public void PrintPackageSlip(string productName)
        {
            Console.WriteLine($"Generated Packaging slip for {productName}");
        }
    }
}
