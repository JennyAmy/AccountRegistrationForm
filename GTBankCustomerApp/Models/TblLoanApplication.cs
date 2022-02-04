using System;
using System.Collections.Generic;

namespace GTBankCustomerApp.Models
{
    public partial class TblLoanApplication
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int? Tenor { get; set; }
        public int? InterestRate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? FirstPayDate { get; set; }
        public string Gender { get; set; }
        public int? PrincipalFreq { get; set; }
        public int? InterestFreq { get; set; }
        public string ProductCode { get; set; }
        public string AccountNumber { get; set; }
        public string PrincipalAmount { get; set; }
    }
}
