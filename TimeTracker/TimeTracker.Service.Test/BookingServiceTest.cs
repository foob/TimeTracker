using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor;
using TimeTracker.Data;
using TimeTracker.Data.TimeTracker.Data;

namespace TimeTracker.Service.Test
{
    [TestClass]
    public class BookingServiceTest
    {
        private static IWindsorContainer _container;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _container = new WindsorContainer();
            new ContainerInstaller().Install(_container, null);
        }


        [TestMethod]
        public void GetByIdTest()
        {
            var modelContainer = new TimeTrackerContext();
            var service = new BookingService(modelContainer);
            var booking = service.GetById(1);
            Assert.IsNotNull(booking);
        }

        [TestMethod]
        public void GetByIdWithContainerTest()
        {
            var service = _container.Resolve<IService<Booking>>();
            var booking = service.GetById(1);
            Assert.IsNotNull(booking);
        }
    }
}
