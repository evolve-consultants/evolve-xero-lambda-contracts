using System;

namespace Monspire.Xero.Lambdas.Contracts
{
    public class ContactsSyncRequestedMessage
    {
        public int TokenId { get; set; }

        public DateTime? ModifiedAfter { get; set; }
    }
}