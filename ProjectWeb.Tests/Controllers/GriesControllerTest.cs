using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectWeb;
using ProjectWeb.Controllers;

namespace ProjectWeb.Tests.Controllers
{
    [TestClass]
    public class GriesControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            GriesController controller = new GriesController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            GriesController controller = new GriesController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            GriesController controller = new GriesController();

            // Act
            ViewResult result = controller.Delete(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Details()
        {
            // Arrange
            GriesController controller = new GriesController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Edit()
        {
            // Arrange
            GriesController controller = new GriesController();

            // Act
            ViewResult result = controller.Edit(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
