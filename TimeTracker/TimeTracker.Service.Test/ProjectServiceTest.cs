using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Castle.Windsor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeTracker.Data;
using TimeTracker.Data.TimeTracker.Data;

namespace TimeTracker.Service.Test
{
    [TestClass]
    public class ProjectServiceTest
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
            var service = new ProjectService(modelContainer);
            var project = service.GetById(2);
            Assert.IsNotNull(project);
        }

        [TestMethod]
        public void GetByIdWithContainerTest()
        {
            var service = _container.Resolve<IService<Project>>();
            var project = service.GetById(2);
            Assert.IsNotNull(project);
        }

        [TestMethod]
        public void SaveProjectTest()
        {
            var service = _container.Resolve<IService<Project>>();
            var project = new Project { Number = "12345", Name = "Bla Blup"};
            service.Save(project);

            Assert.IsNotNull(project);
            Assert.IsTrue(project.Id>0);
        }


    }
}
