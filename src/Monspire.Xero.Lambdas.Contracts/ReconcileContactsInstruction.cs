using System;

namespace Monspire.Xero.Lambdas.Contracts
{
    public class ReconcileContactsInstruction
    {
        public int TenantId { get; set; }

        public DateTime? ModifiedAfter { get; set; }
    }
}