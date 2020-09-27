using System.ComponentModel.DataAnnotations;

namespace LoanWebApp.Models
{
    public class OperationType
    {
        public enum OperationTypeId : int
        {
            Loan = 0,
            Repayment = 1
        }

        public OperationTypeId Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}