using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial.ChangeTrack.Clientside.MVC.Models;

namespace Tutorial.ChangeTrack.Clientside.MVC.Controllers
{
    [RoutePrefix("employee")]
    public class EmployeeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            EmployeeDropdownMenuViewModel model = GetEmployeeDetails();

            return View("~/Views/Employee/Index.cshtml", model);
        }

        private static EmployeeDropdownMenuViewModel GetEmployeeDetails()
        {
            return new EmployeeDropdownMenuViewModel
            {
                Employees = new List<EmployeeDropdownMenuViewModel.EmployeeViewModel>
                 {
                    new EmployeeDropdownMenuViewModel.EmployeeViewModel { Text = "Michael Owen", Value = 1 },
                    new EmployeeDropdownMenuViewModel.EmployeeViewModel { Text = "Jimie Carragher", Value = 2 },
                    new EmployeeDropdownMenuViewModel.EmployeeViewModel { Text = "Sam Smith", Value = 3 },
                    new EmployeeDropdownMenuViewModel.EmployeeViewModel { Text = "Oliver Giroud", Value = 4 },
                    new EmployeeDropdownMenuViewModel.EmployeeViewModel { Text = "Thiery Henry", Value = 5 },
                    new EmployeeDropdownMenuViewModel.EmployeeViewModel { Text = "Diego Maradonna", Value = 6 },
                    new EmployeeDropdownMenuViewModel.EmployeeViewModel { Text = "Gary Neville", Value = 7 }
                 }
            };
        }

        [Route("submit")]
        public ActionResult Submit(FormEditModel model)
        {
            return PartialView("~/Views/Employee/PartialViews/_Success.cshtml", model);
        }
    }
}