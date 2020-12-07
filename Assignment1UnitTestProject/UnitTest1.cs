using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1UnitTestProject;

namespace Assignment1UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Game_class unitTesting_obj = new Game_logic();
            
        [TestMethod]
        public void TestMethod1()
        {
            unitTesting_obj.Load_position = 1;
            unitTesting_obj.Spin_position = 1;
            int testResult = unitTesting_obj.Shoot_method();
            Assert.AreEqual(1, testResult);
        }
        [TestMethod]
        public void Shoot_Test_Neg()
        {
            unitTesting_obj.Load_position = 1;
            unitTesting_obj.Spin_position = 1;
            int testResult = unitTesting_obj.Shoot_method();
            Assert.AreEqual(1, testResult);
        }
    }

    internal class Game_logic : Game_class
    {
    }
}
