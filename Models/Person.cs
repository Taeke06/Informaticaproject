using System.ComponentModel.DataAnnotations;

namespace Informaticaproject.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Het vak 'Voornaam' is verplicht")]
        public string? Firstname { get; set; }
        [Required(ErrorMessage = "Het vak 'Achternaam' is verplicht")]
        public string? Lastname { get; set; }
        [Required(ErrorMessage = "Het vak 'Email' is verplicht")]
        [EmailAddress(ErrorMessage = "Email is ongeldig")]
        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string? Description { get; set; }
    }
}