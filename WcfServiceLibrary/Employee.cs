using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    public class Employee : IEmployee
    {
        private EmployeeManagementService service = new EmployeeManagementService();

        public List<EmployeeDTO> GetEmployees()
        {
            return service.Get();
        }

        public EmployeeDTO GetEmployeeByID(int id)
        {
            return service.GetById(id);
        }

        public string PostEmployee(EmployeeDTO employeeDto)
        {
            if (!service.Save(employeeDto))
                return "Employee is not inserted";

            return "Employee is inserted";
        }

        public string DeleteEmployee(int id)
        {
            if (!service.Delete(id))
                return "Employee is not deleted";

            return "Employee is deleted";
        }
        public string SoftDeleteEmployee(int id)
        {
            if (!service.SoftDelete(id))
                return "Employeeis not soft deleted";

            return "Employee is soft deleted";
        }

        public string Message()
        {
            return "The service is up and running.";
        }
    }
}
