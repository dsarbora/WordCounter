using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterControllerTest
    {
         [TestMethod]
        public void Index_HasCorrectModel_RepeatCounter()
        {
            RepeatCounterController testController = new RepeatCounterController();
            RepeatCounter testCounter = new RepeatCounter("get", "set");
            ViewResult indexView = testController.Index() as ViewResult;
            var result = indexView.ViewData.Model;
            Assert.AreEqual (result, testCounter);
        }
        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            RepeatCounterController testController = new RepeatCounterController();
            ActionResult newView = testController.New();
            Assert.IsInstanceOfType (newView, typeof(ViewResult));
        }
        

    }
}
