using System.ComponentModel.DataAnnotations;
using static LoanWebApp.Models.OperationType;

namespace LoanWebApp.Models
{
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