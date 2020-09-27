using System.ComponentModel.DataAnnotations;

namespace LoanWebApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string OtherNames { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
    }
}