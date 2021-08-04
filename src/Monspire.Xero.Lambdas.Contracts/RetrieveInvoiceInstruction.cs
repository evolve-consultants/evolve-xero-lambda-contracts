using System;

namespace Monspire.Xero.Lambdas.Contracts
{
    public class RetrieveInvoiceInstruction
    {
        public int TenantId { get; set; }

        public Guid InvoiceId { get; set; }
    }
}