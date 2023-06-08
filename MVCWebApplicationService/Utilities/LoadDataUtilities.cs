using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplicationService.Utilities
{
    public class LoadDataUtilities
    {
        public static SelectList LoadCustomersData()
        {
            using (CustomerService.CustomerClient service = new CustomerService.CustomerClient())
            {
                return new SelectList(service.GetCustomers(), "Id", "Title");
            }
        }
        public static SelectList LoadEmployeesData()
        {
            using (EmployeeService.EmployeeClient service = new EmployeeService.EmployeeClient())
            {
                return new SelectList(service.GetEmployees(), "Id", "Title");
            }
        }
    }
}