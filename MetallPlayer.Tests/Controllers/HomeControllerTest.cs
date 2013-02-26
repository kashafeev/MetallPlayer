﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetallPlayer;
using MetallPlayer.Controllers;

namespace MetallPlayer.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Упорядочение
            HomeController controller = new HomeController();

            // Действие
            ViewResult result = controller.Index() as ViewResult;

            // Утверждение
            Assert.AreEqual("Измените этот шаблон, чтобы быстро приступить к работе над приложением ASP.NET MVC.", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            // Упорядочение
            HomeController controller = new HomeController();

            // Действие
            ViewResult result = controller.About() as ViewResult;

            // Утверждение
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact()
        {
            // Упорядочение
            HomeController controller = new HomeController();

            // Действие
            ViewResult result = controller.Contact() as ViewResult;

            // Утверждение
            Assert.IsNotNull(result);
        }
    }
}
