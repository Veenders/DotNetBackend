using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetBackend.Controllers;
using System.Web.Mvc;

namespace dotNetBackend.Tests.Controllers
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class PageControllerTest
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestPage1View()
        {
            PageController controller = new PageController();

            ViewResult result = controller.Page_1() as ViewResult;

            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void TestPage1ViewData()
        {
            PageController controller = new PageController();

            ViewResult result = controller.Page_1() as ViewResult;

            Assert.AreEqual("Page 1", result.ViewData["Page"]);
        }
        [TestMethod]
        public void TestPage2View()
        {
            PageController controller = new PageController();

            ViewResult result = controller.Page_2() as ViewResult;

            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void TestPage2ViewData()
        {
            PageController controller = new PageController();

            ViewResult result = controller.Page_2() as ViewResult;

            Assert.AreEqual("Page 2", result.ViewData["Page"]);
        }
        [TestMethod]
        public void TestPage3View()
        {
            PageController controller = new PageController();

            ViewResult result = controller.Page_3() as ViewResult;

            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void TestPage3ViewData()
        {
            PageController controller = new PageController();

            ViewResult result = controller.Page_3() as ViewResult;

            Assert.AreEqual("Page 3", result.ViewData["Page"]);
        }
    }
}