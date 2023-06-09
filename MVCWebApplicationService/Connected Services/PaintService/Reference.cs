﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWebApplicationService.PaintService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PaintService.IPaint")]
    public interface IPaint {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/Message", ReplyAction="http://tempuri.org/IPaint/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/Message", ReplyAction="http://tempuri.org/IPaint/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/GetPaints", ReplyAction="http://tempuri.org/IPaint/GetPaintsResponse")]
        ApplicationService.DTOs.PaintDTO[] GetPaints();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/GetPaints", ReplyAction="http://tempuri.org/IPaint/GetPaintsResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.PaintDTO[]> GetPaintsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/GetAvailablePaints", ReplyAction="http://tempuri.org/IPaint/GetAvailablePaintsResponse")]
        ApplicationService.DTOs.PaintDTO[] GetAvailablePaints();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/GetAvailablePaints", ReplyAction="http://tempuri.org/IPaint/GetAvailablePaintsResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.PaintDTO[]> GetAvailablePaintsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/GetPaintByID", ReplyAction="http://tempuri.org/IPaint/GetPaintByIDResponse")]
        ApplicationService.DTOs.PaintDTO GetPaintByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/GetPaintByID", ReplyAction="http://tempuri.org/IPaint/GetPaintByIDResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.PaintDTO> GetPaintByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/GetAvailablePaintByID", ReplyAction="http://tempuri.org/IPaint/GetAvailablePaintByIDResponse")]
        ApplicationService.DTOs.PaintDTO GetAvailablePaintByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/GetAvailablePaintByID", ReplyAction="http://tempuri.org/IPaint/GetAvailablePaintByIDResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.PaintDTO> GetAvailablePaintByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/PostPaint", ReplyAction="http://tempuri.org/IPaint/PostPaintResponse")]
        string PostPaint(ApplicationService.DTOs.PaintDTO paintDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/PostPaint", ReplyAction="http://tempuri.org/IPaint/PostPaintResponse")]
        System.Threading.Tasks.Task<string> PostPaintAsync(ApplicationService.DTOs.PaintDTO paintDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/DeletePaint", ReplyAction="http://tempuri.org/IPaint/DeletePaintResponse")]
        string DeletePaint(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/DeletePaint", ReplyAction="http://tempuri.org/IPaint/DeletePaintResponse")]
        System.Threading.Tasks.Task<string> DeletePaintAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/MakePaintUnavailable", ReplyAction="http://tempuri.org/IPaint/MakePaintUnavailableResponse")]
        string MakePaintUnavailable(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaint/MakePaintUnavailable", ReplyAction="http://tempuri.org/IPaint/MakePaintUnavailableResponse")]
        System.Threading.Tasks.Task<string> MakePaintUnavailableAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPaintChannel : MVCWebApplicationService.PaintService.IPaint, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaintClient : System.ServiceModel.ClientBase<MVCWebApplicationService.PaintService.IPaint>, MVCWebApplicationService.PaintService.IPaint {
        
        public PaintClient() {
        }
        
        public PaintClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaintClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaintClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaintClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
        
        public ApplicationService.DTOs.PaintDTO[] GetPaints() {
            return base.Channel.GetPaints();
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.PaintDTO[]> GetPaintsAsync() {
            return base.Channel.GetPaintsAsync();
        }
        
        public ApplicationService.DTOs.PaintDTO[] GetAvailablePaints() {
            return base.Channel.GetAvailablePaints();
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.PaintDTO[]> GetAvailablePaintsAsync() {
            return base.Channel.GetAvailablePaintsAsync();
        }
        
        public ApplicationService.DTOs.PaintDTO GetPaintByID(int id) {
            return base.Channel.GetPaintByID(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.PaintDTO> GetPaintByIDAsync(int id) {
            return base.Channel.GetPaintByIDAsync(id);
        }
        
        public ApplicationService.DTOs.PaintDTO GetAvailablePaintByID(int id) {
            return base.Channel.GetAvailablePaintByID(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.PaintDTO> GetAvailablePaintByIDAsync(int id) {
            return base.Channel.GetAvailablePaintByIDAsync(id);
        }
        
        public string PostPaint(ApplicationService.DTOs.PaintDTO paintDTO) {
            return base.Channel.PostPaint(paintDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostPaintAsync(ApplicationService.DTOs.PaintDTO paintDTO) {
            return base.Channel.PostPaintAsync(paintDTO);
        }
        
        public string DeletePaint(int id) {
            return base.Channel.DeletePaint(id);
        }
        
        public System.Threading.Tasks.Task<string> DeletePaintAsync(int id) {
            return base.Channel.DeletePaintAsync(id);
        }
        
        public string MakePaintUnavailable(int id) {
            return base.Channel.MakePaintUnavailable(id);
        }
        
        public System.Threading.Tasks.Task<string> MakePaintUnavailableAsync(int id) {
            return base.Channel.MakePaintUnavailableAsync(id);
        }
    }
}
