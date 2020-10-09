using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Rules.Interface
{
    public interface IPackageable
    {
        void GeneratePackagingSlip(string productName, int noOfCopy = 0);
    }
}
