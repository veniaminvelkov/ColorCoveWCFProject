using ApplicationService.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        string Message();

        [OperationContract]
        List<CustomerDTO> GetCustomers();

        [OperationContract]
        CustomerDTO GetCustomerByID(int id);

        [OperationContract]
        string PostCustomer(CustomerDTO customerDto);

        [OperationContract]
        string DeleteCustomer(int id);

        [OperationContract]
        string SoftDeleteCustomer(int id);
    }
}
