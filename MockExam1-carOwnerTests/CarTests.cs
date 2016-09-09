using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockExam1_carOwner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExam1_carOwner.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTest()
        {
            Car c = new Car(Car.CarColor.Blue, 5, "Fabia", "AB12345");
            //Console.WriteLine(c);
            Assert.AreEqual(c.ToString(), "Fabia AB12345 Blue 5");
        }

        [TestMethod()]
        public void CarTest1()
        {
            Car c = new Car("Fabia", "AB12345");
            //Console.WriteLine(c);
            Assert.AreEqual(c.ToString(), "Fabia AB12345 White 5");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            
        }
    }
}