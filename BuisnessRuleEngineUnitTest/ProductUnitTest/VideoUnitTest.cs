using BusinessRuleEngine;
using BusinessRuleEngine.Rules.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProductDataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessRuleEngineUnitTest.ProductUnitTest
{
    [TestClass]
    public class VideoUnitTest
    {
        Mock<IPackageable> _packageableMock;
        Video _book;

        [TestInitialize]
        public void Setup()
        {
            _packageableMock = new Mock<IPackageable>();
            _book = new Video(_packageableMock.Object);
        }
        [TestMethod]
        public void ProcessOrderCheckIfPackagingSlipIsCalled()
        {
            _book.ProcessOrder(new VideoModel() { Name="Something"});
            _packageableMock.Verify((mock) => mock.GeneratePackagingSlip(It.IsAny<string>(), It.IsAny<int>()), Times.Exactly(1));
        }

        [TestMethod]
        public void ProcessOrderCheckIfPackagingSlipIsCalledWithNewVideoAddition()
        {
            _book.ProcessOrder(new VideoModel() { Name = "Learning to ski" });
            _packageableMock.Verify((mock) => mock.GeneratePackagingSlip("Learning to Ski Video and First aid", It.IsAny<int>()), Times.Exactly(1));
        }
    }
}
