using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCdemo1.Models;

namespace MVCdemo1.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        public ActionResult View()
        {
			var Employee = new employee() { Name = "gary" };
				return View(Employee);
        }
    }
}