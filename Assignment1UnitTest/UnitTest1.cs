﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace Assignment1UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Game_logic_form unitTesting_obj = new Game_logic_form();
        [TestMethod]
        public void Shoot_Test()
        {
            unitTesting_obj.load_data = 1;
            unitTesting_obj.spin_data = 1;
            int testResult = unitTesting_obj.shoot_method();
            Assert.AreEqual(1, testResult);
        }
        [TestMethod]
        public void Shoot_Test_Neg()
        {
            unitTesting_obj.load_data = 1;
            unitTesting_obj.spin_data = 5;
            int testResult = unitTesting_obj.shoot_method();
            Assert.AreNotEqual(1, testResult);

        }
    }
}
