﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client2.svc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="svc.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        string Add(string arg1, string arg2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtract", ReplyAction="http://tempuri.org/ICalculator/SubtractResponse")]
        string Subtract(string arg1, string arg2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        string Multiply(string arg1, string arg2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
        string Divide(string arg1, string arg2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICalculatorChannel : Client2.svc.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<Client2.svc.ICalculator>, Client2.svc.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Add(string arg1, string arg2) {
            return base.Channel.Add(arg1, arg2);
        }
        
        public string Subtract(string arg1, string arg2) {
            return base.Channel.Subtract(arg1, arg2);
        }
        
        public string Multiply(string arg1, string arg2) {
            return base.Channel.Multiply(arg1, arg2);
        }
        
        public string Divide(string arg1, string arg2) {
            return base.Channel.Divide(arg1, arg2);
        }
    }
}