using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Redbus_API.Controllers;
using System.Net.Http;

namespace Redbus_API.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            HttpResponseMessage result = controller.GetAllBuses() as HttpResponseMessage;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
        }
    }
}
