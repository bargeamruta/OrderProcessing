using BusinessRuleEngine;
using BusinessRuleEngine.Rules.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessRuleEngineUnitTest.ProductUnitTest
{
    [TestClass]
    public class PhysicalProductUnitTest
    {
        Mock<IPackageable> _packageableMock;
        Mock<IAgentCommission> _agentCommMock;
        PhysicalProduct _physicalProduct;

        [TestInitialize]
        public void Setup()
        {
            _packageableMock = new Mock<IPackageable>();
            _agentCommMock = new Mock<IAgentCommission>();
            _physicalProduct = new PhysicalProduct(_packageableMock.Object, _agentCommMock.Object);
        }
        [TestMethod]
        public void ProcessOrderCheckIfPackaginSlipandAgentComIsCalled()
        {
            _physicalProduct.ProcessOrder(null);
            _packageableMock.Verify((mock) => mock.GeneratePackagingSlip(It.IsAny<string>(), It.IsAny<int>()), Times.Exactly(1));
            _agentCommMock.Verify((mock) => mock.GenerateCommissionPaymentToAgent(), Times.Exactly(1));
        }
    }
}
