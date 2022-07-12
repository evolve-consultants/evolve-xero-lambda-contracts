using System;

namespace Monspire.Xero.Lambdas.Contracts
{
    public class InvoiceSyncRequestedMessage
    {
        public int TenantId { get; set; }

        public Guid InvoiceId { get; set; }

        public Guid XeroTenantId { get; set; }
    }
}