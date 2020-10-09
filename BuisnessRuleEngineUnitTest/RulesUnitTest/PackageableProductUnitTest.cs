using System;
using System.Collections.Generic;
using System.Text;
using BusinessRuleEngine.Rules.Implementation;
using BusinessRuleEngine.Rules.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BuisnessRuleEngineUnitTest.RulesUnitTest
{
    [TestClass]
    public class PackageableProductUnitTest
    {
        Mock<IPrint> _printMock;
        PackageableProduct packageableProduct;
        [TestInitialize]
        public void Setup()
        {
            _printMock = new Mock<IPrint>();
            packageableProduct = new PackageableProduct(_printMock.Object);
        }
        [TestMethod]
        public void GeneratePackagingSlipIfNoOfCopyIsDefaultCreateOneCopy()
        {
            packageableProduct.GeneratePackagingSlip("productName", 0);
            _printMock.Verify((mock) => mock.PrintPackageSlip("productName"), Times.Exactly(1));
        }

        [TestMethod]
        public void GeneratePackagingSlipIfNoOfCopyIs2Create2Copy()
        {
            packageableProduct.GeneratePackagingSlip("productName", 2);
            _printMock.Verify((mock) => mock.PrintPackageSlip("productName"), Times.Exactly(2));
        }
    }
}
