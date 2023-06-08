using ApplicationService.DTOs;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Implementations
{
    public class EmployeeManagementService
    {
        public List<EmployeeDTO> Get()
        {
            List<EmployeeDTO> employeeDTO = new List<EmployeeDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.EmployeeRepository.Get())
                {
                    if (item.IsSoftDeleted == false)
                    {
                        employeeDTO.Add(new EmployeeDTO
                        {
                            Id = item.Id,
                            Username = item.Username,
                            Password = item.Password,
                            FirstName = item.FirstName,
                            LastName = item.LastName
                        });
                    }
                }
            }
            return employeeDTO;
        }
        public EmployeeDTO GetById(int id)
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Employee employee = unitOfWork.EmployeeRepository.GetByID(id);
                if (employee != null && employee.IsSoftDeleted == false)
                {
                    employeeDTO = new EmployeeDTO
                    {
                        Id = employee.Id,
                        Username = employee.Username,
                        Password = employee.Password,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName
                    };
                }
            }
            return employeeDTO;
        }
        public bool Save(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee
            {
                Id = employeeDTO.Id,
                Username = employeeDTO.Username,
                Password = employeeDTO.Password,
                FirstName = employeeDTO.FirstName,
                LastName = employeeDTO.LastName,
                IsSoftDeleted = false,
                DateHired= DateTime.Now
            };

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.EmployeeRepository.Delete(employee.Id);
                unitOfWork.EmployeeRepository.Insert(employee);
                unitOfWork.Save();
            }
            return true;
        }
        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Employee employee = unitOfWork.EmployeeRepository.GetByID(id);
                    unitOfWork.EmployeeRepository.Delete(employee);
                    unitOfWork.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SoftDelete(int id)
        {

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Employee employee = unitOfWork.EmployeeRepository.GetByID(id);
                employee.IsSoftDeleted = true;
                unitOfWork.Save();
            }

            return true;
        }
    }
}
