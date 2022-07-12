using System;

namespace Monspire.Xero.Lambdas.Contracts
{
    public class SyncInvoiceMessage
    {
        public int TenantId { get; set; }

        public Guid XeroTenantId { get; set; }

        public string XeroInvoiceJsonData { get; set; }

    }
}
