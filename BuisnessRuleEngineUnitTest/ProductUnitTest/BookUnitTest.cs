using BusinessRuleEngine.Rules.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessRuleEngine;
using System;
using System.Collections.Generic;
using System.Text;
using ProductDataModel;

namespace BuisnessRuleEngineUnitTest.ProductUnitTest
{
    [TestClass]
    public class BookUnitTest
    {
        Mock<IPackageable> _packageableMock;
        Mock<IAgentCommission> _agentCommMock;
        Book _book;

        [TestInitialize]
        public void Setup()
        {
            _packageableMock = new Mock<IPackageable>();
            _agentCommMock = new Mock<IAgentCommission>();
            _book = new Book(_packageableMock.Object,_agentCommMock.Object);
        }
        [TestMethod]
        public void ProcessOrderCheckIfPackaginSlipandAgentComIsCalled()
        {
            _book.ProcessOrder(null);
            _packageableMock.Verify((mock) => mock.GeneratePackagingSlip(It.IsAny<string>(),It.IsAny<int>()), Times.Exactly(1));
            _agentCommMock.Verify((mock) => mock.GenerateCommissionPaymentToAgent(), Times.Exactly(1));
        }

    }
}
