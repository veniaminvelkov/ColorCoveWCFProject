using ApplicationService.DTOs;
using ApplicationService.Implementations;
using MVCWebApplicationService.Utilities;
using MVCWebApplicationService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplicationService.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            List<CustomerViewModel> studentVM = new List<CustomerViewModel>();
            using (CustomerService.CustomerClient service = new CustomerService.CustomerClient())
            {
                foreach (var item in service.GetCustomers())
                {
                    studentVM.Add(new CustomerViewModel(item));
                }
            }
            return View(studentVM);
        }

        public ActionResult Details(int id)
        {
            CustomerViewModel studentVM = new CustomerViewModel();
            using (CustomerService.CustomerClient service = new CustomerService.CustomerClient())
            {
                var customerDTO = service.GetCustomerByID(id);
                studentVM = new CustomerViewModel(customerDTO);
            }

            return View(studentVM);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Customers = LoadDataUtilities.LoadCustomersData();

            CustomerViewModel customerVM = new CustomerViewModel();
            using (CustomerService.CustomerClient service = new CustomerService.CustomerClient())
            {
                var customerDTO = service.GetCustomerByID(id);
                customerVM = new CustomerViewModel(customerDTO);
            }

            return View(customerVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerViewModel customerVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (CustomerService.CustomerClient service = new CustomerService.CustomerClient())
                    {
                        CustomerDTO customerDTO = new CustomerDTO
                        {
                            Id = customerVM.Id,
                            FirstName = customerVM.FirstName,
                            LastName = customerVM.LastName,
                            Username = customerVM.Username,
                            Password = customerVM.Password,

                        };
                        service.PostCustomer(customerDTO);
                    }

                    return RedirectToAction("Index");
                }
                ViewBag.Customers = LoadDataUtilities.LoadCustomersData();
                return View();
            }
            catch
            {
                ViewBag.Customers = LoadDataUtilities.LoadCustomersData();
                return View();
            }
        }

        public ActionResult Delete(int id)
        {

            using (CustomerService.CustomerClient service = new CustomerService.CustomerClient())
            {
                service.DeleteCustomer(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            ViewBag.Customers = LoadDataUtilities.LoadCustomersData();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerViewModel customerVM)
        {
            try
            {
                using (CustomerService.CustomerClient service = new CustomerService.CustomerClient())
                {
                    CustomerDTO studentDTO = new CustomerDTO
                    {
                        FirstName = customerVM.FirstName,
                        LastName = customerVM.LastName,
                        Username = customerVM.Username,
                        Password = customerVM.Password,
                    };
                    service.PostCustomer(studentDTO);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Nationalities = LoadDataUtilities.LoadCustomersData();
                return View();
            }
        }
    }
}