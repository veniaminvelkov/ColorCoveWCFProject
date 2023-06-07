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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in both code and config file together.
    public class Customer : ICustomer
    {
        private CustomerManagementService service = new CustomerManagementService();

        public List<CustomerDTO> GetCustomers()
        {
            return service.Get();
        }

        public CustomerDTO GetCustomerByID(int id)
        {
            return service.GetById(id);
        }

        public string PostCustomer(CustomerDTO customerDto)
        {
            if (!service.Save(customerDto))
                return "Customer is inserted";

            return "Customer is not inserted";
        }

        public string DeleteCustomer(int id)
        {
            if (!service.Delete(id))
                return "Customer is not deleted";

            return "Customer is deleted";
        }
        public string SoftDeleteCustomer(int id)
        {
            if (!service.SoftDelete(id))
                return "Customer is not soft deleted";

            return "Customer is soft deleted";
        }

        public string Message()
        {
            return "The service is up and running.";
        }
    }
}
