using LoanWebApp.Models;

namespace LoanWebApp.DerivedModels
{
    public class PersonDetails : Person
    {
        public decimal AmountLoanedToOthers { get; set; }
        public decimal AmountLoanedFromOthers { get; set; }
        public decimal Total => AmountLoanedFromOthers - AmountLoanedToOthers;
    }
}