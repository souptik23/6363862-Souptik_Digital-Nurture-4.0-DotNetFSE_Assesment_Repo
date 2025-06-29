using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestClass]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mockMailSender;
        private CustomerComm _customerComm;

        [TestInitialize]
        public void Setup()
        {
            _mockMailSender = new Mock<IMailSender>();
            _mockMailSender
                .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            _customerComm = new CustomerComm(_mockMailSender.Object);
        }

        [TestMethod]
        public void SendMailToCustomer_ShouldReturnTrue_WhenMailIsSent()
        {
            // Act
            var result = _customerComm.SendMailToCustomer();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SendMailToCustomer_ShouldCallSendMailOnce()
        {
            // Act
            _customerComm.SendMailToCustomer();

            // Assert
            _mockMailSender.Verify(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}
