using System.ComponentModel.DataAnnotations;

namespace LoanWebApp.Models
{
    /// <summary>
    /// Class for operations (loan or repayment)
    /// </summary>
    public class Operation
    {
        public int Id { get; set; }

        [Required]
        public OperationType OperationType { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public Person PersonFrom { get; set; }

        [Required]
        public Person PersonTo { get; set; }
    }
}