using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonMasterDetail.Models;

namespace PersonMasterDetail.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var people = PersonDB.GetPeople();
            var viewModel = new AllPersonsViewModel { People = people };
            return View(viewModel);
        }

        public ActionResult Show(int id)
        {
            var person = PersonDB.GetPeople().First(p => p.Id == id);
            var viewModel = new PersonViewModel();
            viewModel.Person = person;
            return View(viewModel);

        }
    }
}
