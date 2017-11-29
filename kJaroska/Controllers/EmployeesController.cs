using System;
using System.Linq;
using System.Web.Mvc;
using kJaroska.Models;

namespace kJaroska.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeDb _db = new EmployeeDb();


        public ActionResult List()
        {
            var employeeList = _db.Employees.ToList();

            return View(employeeList);
        }

        public PartialViewResult SortByNames(string query)
        {
            var viewModel = _db.Employees.Where(e => e.LastName == query).Take(10).ToList();

            return PartialView("TableBody", viewModel);
        }

        public PartialViewResult SortByDates(string from, string to)
        {
            var dateFrom = Convert.ToDateTime(from);
            var dateTo = Convert.ToDateTime(to);
            var viewModel = _db.Employees.Where(e => e.HireDate >= dateFrom && e.HireDate <= dateTo).ToList();

            return PartialView("TableBody", viewModel);
        }

        public PartialViewResult SortByDepartments(string department)
        {
            var viewModel = _db.Employees.Where(e => e.Department == department).Take(10).ToList();

            return PartialView("TableBody", viewModel);
        }

        public PartialViewResult SortByGrades(int grade)
        {
            var viewModel = _db.Employees.Where(e => e.Grade == grade).Take(10).ToList();

            return PartialView("TableBody", viewModel);
        }

        public PartialViewResult SortByManager(string firstName, string lastName)
        {
            var viewModel = _db.Employees.Where(e => e.Manager.FirstName == firstName && e.Manager.LastName == lastName).Take(10).ToList();

            return PartialView("TableBody", viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
