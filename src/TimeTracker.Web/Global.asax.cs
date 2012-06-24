using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.SessionState;
using TimeTracker.Web.Controllers;
using TimeTracker.Web.Data;

namespace TimeTracker.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory(ControllerBuilder.Current.GetControllerFactory()));
        }
    }

    public class CustomControllerFactory : IControllerFactory
    {
        private readonly IControllerFactory _innerControllerFactory;

        public CustomControllerFactory(IControllerFactory innerControllerFactory)
        {
            _innerControllerFactory = innerControllerFactory;
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName.Equals("Home"))
            {
                return new HomeController(Repository.Default);
            }
            else if (controllerName.Equals("Booking"))
            {
                return new BookingController(Repository.Default);
            }
            return _innerControllerFactory.CreateController(requestContext, controllerName);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return _innerControllerFactory.GetControllerSessionBehavior(requestContext, controllerName);
        }

        public void ReleaseController(IController controller)
        {
            _innerControllerFactory.ReleaseController(controller);
        }
    }
}