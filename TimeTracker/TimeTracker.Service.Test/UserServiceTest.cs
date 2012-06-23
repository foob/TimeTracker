using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor;
using TimeTracker.Data;
using TimeTracker.Data.TimeTracker.Data;

namespace TimeTracker.Service.Test
{
	[TestClass]
	public class UserServiceTest
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
			var service = new UserService(modelContainer);
			var user = service.GetById(2);
			Assert.IsNotNull(user);
		}

		[TestMethod]
		public void GetByIdWithContainerTest()
		{
			var service = _container.Resolve<IService<User>>();
			var user = service.GetById(2);
			Assert.IsNotNull(user);
		}

        [TestMethod]
        public void SaveUserTest()
        {
            var service = _container.Resolve<IService<User>>();
            var user = new User {AccountName = "YvesM"};
            var project = new Project {Name = "Test", Number = "1234"};
            user.Projects.Add(project);
            service.Save(user);
            Assert.IsNotNull(user);
        }
	}
}
