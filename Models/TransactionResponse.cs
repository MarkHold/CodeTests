using System;

namespace WebPrefer.Tests.Models
{
    public class TransactionResponse
    { 
        public string TransactionId {get; set;}
        
        public decimal Balance {get; set;}

        public string ErrorCode {get; set;}

        public string ErrorMessage {get; set;}
    }
}