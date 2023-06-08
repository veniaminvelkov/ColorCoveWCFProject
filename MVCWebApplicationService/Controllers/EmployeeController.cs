using ApplicationService.DTOs;
using MVCWebApplicationService.Utilities;
using MVCWebApplicationService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplicationService.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            List<EmployeeViewModel> employeeVM = new List<EmployeeViewModel>();
            using (EmployeeService.EmployeeClient service = new EmployeeService.EmployeeClient())
            {
                foreach (var item in service.GetEmployees())
                {
                    employeeVM.Add(new EmployeeViewModel(item));
                }
            }
            return View(employeeVM);
        }

        public ActionResult Details(int id)
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            using (EmployeeService.EmployeeClient service = new EmployeeService.EmployeeClient())
            {
                var employeeDTO = service.GetEmployeeByID(id);
                employeeVM = new EmployeeViewModel(employeeDTO);
            }

            return View(employeeVM);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Employees = LoadDataUtilities.LoadEmployeesData();

            EmployeeViewModel employeeVM = new EmployeeViewModel();
            using (EmployeeService.EmployeeClient service = new EmployeeService.EmployeeClient())
            {
                var employeeDTO = service.GetEmployeeByID(id);
                employeeVM = new EmployeeViewModel(employeeDTO);
            }

            return View(employeeVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeViewModel employeeVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (EmployeeService.EmployeeClient service = new EmployeeService.EmployeeClient())
                    {
                        EmployeeDTO employeeDTO = new EmployeeDTO
                        {
                            Id = employeeVM.Id,
                            FirstName = employeeVM.FirstName,
                            LastName = employeeVM.LastName,
                            Username = employeeVM.Username,
                            Password = employeeVM.Password,

                        };
                        service.PostEmployee(employeeDTO);
                    }

                    return RedirectToAction("Index");
                }
                ViewBag.Employees = LoadDataUtilities.LoadEmployeesData();
                return View();
            }
            catch
            {
                ViewBag.Employees = LoadDataUtilities.LoadEmployeesData();
                return View();
            }
        }

        public ActionResult Delete(int id)
        {

            using (EmployeeService.EmployeeClient service = new EmployeeService.EmployeeClient())
            {
                service.DeleteEmployee(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            ViewBag.Employees = LoadDataUtilities.LoadEmployeesData();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeViewModel employeeVM)
        {
            try
            {
                using (EmployeeService.EmployeeClient service = new EmployeeService.EmployeeClient())
                {
                    EmployeeDTO employeeDTO = new EmployeeDTO
                    {
                        FirstName = employeeVM.FirstName,
                        LastName = employeeVM.LastName,
                        Username = employeeVM.Username,
                        Password = employeeVM.Password,
                    };
                    service.PostEmployee(employeeDTO);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Employees = LoadDataUtilities.LoadEmployeesData();
                return View();
            }
        }
    }
}