using Microsoft.AspNetCore.Mvc;
using Paycompute.Models;
using Paycompute.Serivces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeSerice;

        public EmployeeController(IEmployeeService employeeSerice)
        {
            _employeeSerice = employeeSerice;
        }

        public IActionResult Index()
        {
            var employees = _employeeSerice.GetAll().Select(employee => new EmployeeIndexViewModel
            {
                Id = employee.Id,
                EmployeeNo = employee.EmployeeNo,
                ImageUrl = employee.ImageUrl,
                FullName = employee.FullName,
                Gender = employee.Gender,
                Designation = employee.Designation,
                City = employee.City,
                DateJoined = employee.DateJoined
            }).ToList();
            return View(employees);
        }
    }
}
