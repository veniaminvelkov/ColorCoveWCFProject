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
    public class CustomerManagementService
    {
        public List<CustomerDTO> Get()
        {
            List<CustomerDTO> customerDTO = new List<CustomerDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.CustomerRepository.Get())
                {
                    if (item.IsSoftDeleted == false)
                    {
                        customerDTO.Add(new CustomerDTO
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
            return customerDTO;
        }
        public CustomerDTO GetById(int id)
        {
            CustomerDTO customerDTO = new CustomerDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Customer customer = unitOfWork.CustomerRepository.GetByID(id);
                if (customer != null && customer.IsSoftDeleted == false)
                {
                    customerDTO = new CustomerDTO
                    {
                        Id = customer.Id,
                        Username = customer.Username,
                        Password = customer.Password,
                        FirstName = customer.FirstName,
                        LastName = customer.LastName
                    };
                }
            }
            return customerDTO;
        }
        public bool Save(CustomerDTO customerDTO)
        {
            Customer customer = new Customer
            {
                Id= customerDTO.Id,
                Username= customerDTO.Username,
                Password= customerDTO.Password,
                FirstName = customerDTO.FirstName,
                LastName = customerDTO.LastName,
                IsSoftDeleted = false,
                DateRegistered = DateTime.Now
            };

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.CustomerRepository.Delete(customer.Id);
                    unitOfWork.CustomerRepository.Insert(customer);
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
                    Customer customer = unitOfWork.CustomerRepository.GetByID(id);
                    unitOfWork.CustomerRepository.Delete(customer);
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
                    Customer customer = unitOfWork.CustomerRepository.GetByID(id);
                    customer.IsSoftDeleted = true;
                    unitOfWork.Save();
                }
            
                return true;
        }
    }
}
