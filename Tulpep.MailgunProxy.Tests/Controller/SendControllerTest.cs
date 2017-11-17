using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;
using Tulpep.MailgunProxy.Controllers;
using Tulpep.Signtul.Entities;

namespace Tulpep.MailgunProxy.Tests.Controller
{
    [TestClass]
    public class SendControllerTest
    {
        [TestMethod]
        public async Task Post()
        {
            SendController controller = new SendController();
            EmailMessage emailMessage = new EmailMessage
            {
                From = "test@test.com",
                To = "test@test.com",
                Subject = "Hello World",
                Message = "Hello world body!!!"
            };
            var result = await controller.Post(emailMessage);
            Assert.AreEqual(HttpStatusCode.OK, result);
        }
    }
}
