using System;

namespace Monspire.Xero.Lambdas.Contracts
{
    public class ContactsSyncedInvoicesSyncRequestedMessage
    {
        public int TokenId { get; set; }

        public DateTime? ModifiedAfter { get; set; }
    }
}
