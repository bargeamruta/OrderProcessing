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
    public class MembershipUnitTest
    {
        Mock<INotification> _notificationMock;
        Membership _membership;

        [TestInitialize]
        public void Setup()
        {
            _notificationMock = new Mock<INotification>();
            _membership = new Membership(_notificationMock.Object);
        }

        [TestMethod]
        public void ProcessOrderCheckIfSendEmailForActivationIsCalled()
        {
            _membership.ProcessOrder(new MembershipModel() { IsActivation=true });
            _notificationMock.Verify((mock) => mock.SendEmail("Email membership activated"), Times.Exactly(1));
        }

        [TestMethod]
        public void ProcessOrderCheckIfSendEmailForUpgradeIsCalled()
        {
            _membership.ProcessOrder(new MembershipModel() { IsUpgrade = true });
            _notificationMock.Verify((mock) => mock.SendEmail("Email membership upgraded"), Times.Exactly(1));
        }

        [TestMethod]
        public void ProcessOrderCheckIfNoActivationOrUpgradeSendEmailIsNotCalled()
        {
            _membership.ProcessOrder(null);
            _notificationMock.Verify((mock) => mock.SendEmail(It.IsAny<string>()), Times.Never);
        }
    }
}
