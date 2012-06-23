using System.Web.Mvc;
using TimeTracker.Web.Data;

namespace TimeTracker.Web.Controllers
{
    public abstract class MyControllerBase : Controller
    {
        protected MyControllerBase(IRepository repository)
        {
            Repository = repository;
        }

        public IRepository Repository { get; private set; }
    }
}