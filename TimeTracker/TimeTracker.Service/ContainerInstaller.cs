using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TimeTracker.Data;

namespace TimeTracker.Service
{
    public class ContainerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<TimeTrackerDataModelContainer>());
            container.Register(Component.For<IService<Project>>().ImplementedBy<ProjectService>().LifeStyle.Transient);
            container.Register(Component.For<IService<Booking>>().ImplementedBy<BookingService>().LifeStyle.Transient);
        }
    }
}
