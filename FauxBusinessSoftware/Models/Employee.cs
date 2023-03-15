using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FauxBusinessSoftware.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [StringLength(35)]
        public string Firstname { get; set; }

        [StringLength(35)]
        public string Lastname { get; set; }

        [StringLength(100)]
        public string Jobtitle { get; set; }

        [StringLength(35)]
        public string Paymenttype { get; set; }

        [StringLength(12)]
        public string Primaryphone { get; set; }

        [StringLength(12)]
        public string? Secondaryphone { get; set;}

        [StringLength(255)]
        public string? Email { get; set; }
    }
}
