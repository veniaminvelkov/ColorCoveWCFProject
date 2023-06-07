using ApplicationService.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
        string Message();

        [OperationContract]
        List<EmployeeDTO> GetEmployees();

        [OperationContract]
        EmployeeDTO GetEmployeeByID(int id);

        [OperationContract]
        string PostEmployee(EmployeeDTO employeeDto);

        [OperationContract]
        string DeleteEmployee(int id);

        [OperationContract]
        string SoftDeleteEmployee(int id);
    }
}
