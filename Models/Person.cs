using System.ComponentModel.DataAnnotations;

namespace Informaticaproject.Models
{
    public class Person
    {
        [Required]
        public string? Firstname { get; set; }
        [Required]
        public string? Lastname { get; set; }
        [Required]
        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string? Description { get; set; }
    }
}