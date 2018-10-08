using System;

namespace WebPrefer.Tests.Models
{
    public class BetRequest
    {
        public int PlayerId {get; set;}
        
        public string Game {get; set;}
        
        public string TransactionId {get; set;}
        
        public string Currency {get; set;}

        public decimal Amount {get; set;}

        public long RoundId {get; set;}
    }
}