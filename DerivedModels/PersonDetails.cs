using LoanWebApp.Models;

namespace LoanWebApp.DerivedModels
{
    /// <summary>
    /// Class for person list view
    /// </summary>
    public class PersonDetails : Person
    {
        /// <summary>
        /// AmountLoanedToOthers = Sum of money given away - Sum of money received back
        /// </summary>
        public decimal AmountLoanedToOthers { get; set; }

        /// <summary>
        /// AmountLoanedFromOthers = Sum of money taken - Sum of money returned back
        /// </summary>
        public decimal AmountLoanedFromOthers { get; set; }

        public decimal Total => AmountLoanedFromOthers - AmountLoanedToOthers;
    }
}