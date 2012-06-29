using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeTracker.Web.Data;
using TimeTracker.Web.Models;

namespace TimeTracker.Web.Controllers
{
    public class HomeController : MyControllerBase
    {
        public HomeController(IRepository repository) : base(repository)
        {
        }

        public ActionResult Index()
        {
            return View(Repository.Projects);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Project project)
        {
            Repository.Add(project);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            return View(Repository.GetProject(id));
        }

        [HttpPost]
        public ActionResult Edit(Project project)
        {
            Repository.Update(project);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            return View(Repository.GetProject(id));
        }

        [HttpPost]
        public ActionResult Delete(Project project)
        {
            Repository.Delete(project);

            return RedirectToAction("Index");
        }
    }
}