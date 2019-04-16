using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetBackend.Controllers;
using System.Web.Mvc;
using Xania.AspNet.Simulator;
using FluentAssertions;

namespace dotNetBackend.Tests.Controllers
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RolesAdminControllerTest
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
        public void TestIndexUnAuthorized()
        {
            var action = new RolesAdminController().Action(c => c.Index());

            ActionResult result = action.GetAuthorizationResult();

            result.Should().BeOfType<HttpUnauthorizedResult>();
        }
        [TestMethod]
        public void TestIndexAuthorized()
        {
            var action = new RolesAdminController().Action(c => c.Index())
                .Authenticate("user1", new[] { "ADMIN" });

            var result = action.GetAuthorizationResult();
            
            result.Should().BeNull(); 
        }
    }
}