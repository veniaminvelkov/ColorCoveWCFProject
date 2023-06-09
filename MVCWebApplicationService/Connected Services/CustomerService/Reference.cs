﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWebApplicationService.CustomerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerService.ICustomer")]
    public interface ICustomer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/Message", ReplyAction="http://tempuri.org/ICustomer/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/Message", ReplyAction="http://tempuri.org/ICustomer/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/GetCustomers", ReplyAction="http://tempuri.org/ICustomer/GetCustomersResponse")]
        ApplicationService.DTOs.CustomerDTO[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/GetCustomers", ReplyAction="http://tempuri.org/ICustomer/GetCustomersResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.CustomerDTO[]> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/GetCustomerByID", ReplyAction="http://tempuri.org/ICustomer/GetCustomerByIDResponse")]
        ApplicationService.DTOs.CustomerDTO GetCustomerByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/GetCustomerByID", ReplyAction="http://tempuri.org/ICustomer/GetCustomerByIDResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.CustomerDTO> GetCustomerByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/PostCustomer", ReplyAction="http://tempuri.org/ICustomer/PostCustomerResponse")]
        string PostCustomer(ApplicationService.DTOs.CustomerDTO customerDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/PostCustomer", ReplyAction="http://tempuri.org/ICustomer/PostCustomerResponse")]
        System.Threading.Tasks.Task<string> PostCustomerAsync(ApplicationService.DTOs.CustomerDTO customerDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomer/DeleteCustomerResponse")]
        string DeleteCustomer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomer/DeleteCustomerResponse")]
        System.Threading.Tasks.Task<string> DeleteCustomerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/SoftDeleteCustomer", ReplyAction="http://tempuri.org/ICustomer/SoftDeleteCustomerResponse")]
        string SoftDeleteCustomer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/SoftDeleteCustomer", ReplyAction="http://tempuri.org/ICustomer/SoftDeleteCustomerResponse")]
        System.Threading.Tasks.Task<string> SoftDeleteCustomerAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerChannel : MVCWebApplicationService.CustomerService.ICustomer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerClient : System.ServiceModel.ClientBase<MVCWebApplicationService.CustomerService.ICustomer>, MVCWebApplicationService.CustomerService.ICustomer {
        
        public CustomerClient() {
        }
        
        public CustomerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
        
        public ApplicationService.DTOs.CustomerDTO[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.CustomerDTO[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public ApplicationService.DTOs.CustomerDTO GetCustomerByID(int id) {
            return base.Channel.GetCustomerByID(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.CustomerDTO> GetCustomerByIDAsync(int id) {
            return base.Channel.GetCustomerByIDAsync(id);
        }
        
        public string PostCustomer(ApplicationService.DTOs.CustomerDTO customerDto) {
            return base.Channel.PostCustomer(customerDto);
        }
        
        public System.Threading.Tasks.Task<string> PostCustomerAsync(ApplicationService.DTOs.CustomerDTO customerDto) {
            return base.Channel.PostCustomerAsync(customerDto);
        }
        
        public string DeleteCustomer(int id) {
            return base.Channel.DeleteCustomer(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteCustomerAsync(int id) {
            return base.Channel.DeleteCustomerAsync(id);
        }
        
        public string SoftDeleteCustomer(int id) {
            return base.Channel.SoftDeleteCustomer(id);
        }
        
        public System.Threading.Tasks.Task<string> SoftDeleteCustomerAsync(int id) {
            return base.Channel.SoftDeleteCustomerAsync(id);
        }
    }
}
