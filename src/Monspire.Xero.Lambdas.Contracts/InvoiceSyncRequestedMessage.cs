using System;

namespace Monspire.Xero.Lambdas.Contracts
{
    public class InvoiceSyncRequestedMessage
    {
        public int TokenId { get; set; }

        public Guid InvoiceId { get; set; }

        public Guid XeroTenantId { get; set; }
    }
}