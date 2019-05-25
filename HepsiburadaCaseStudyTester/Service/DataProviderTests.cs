using Microsoft.VisualStudio.TestTools.UnitTesting;
using HepsiburadaCaseStudy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCaseStudy.Service.Tests
{
    [TestClass()]
    public class DataProviderTests
    {
        [TestMethod()]
        public void getPlateuSizeTest()
        {
            var dataProvider = new DataProvider();
            Assert.IsNotNull(dataProvider.getPlateuSize());
        }

        [TestMethod()]
        public void getRobotCoordinatesTest()
        {
            var dataProvider = new DataProvider();
            Assert.IsNotNull(dataProvider.getRobotCoordinates());
        }

        [TestMethod()]
        public void getDirectionsTest()
        {
            var dataProvider = new DataProvider();
            Assert.IsNotNull(dataProvider.getDirections());
        }
    }
}