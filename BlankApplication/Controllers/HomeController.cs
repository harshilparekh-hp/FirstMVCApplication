using BlankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlankApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id)
        {
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
            Employee emp = employeeBusinessLogic.GetEmployee(id);

            // we can pass the model data from controller to view using ViewData, ViewBag and TempData. 

            // passing employee model to the view using ViewData

            // Represents a container that is used to pass data between a controller and a view

            ViewData["EmployeeData"] = emp; // passing employee object to ViewData
            ViewData["Header"] = "Employee Details"; // passing string to ViewData
            return View();
        }

    
    }
}