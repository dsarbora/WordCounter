using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            HomeController testController = new HomeController();
            ActionResult indexView = testController.Index();
            Assert.IsInstanceOfType (indexView, typeof(ViewResult));            
        }
       
    }
}