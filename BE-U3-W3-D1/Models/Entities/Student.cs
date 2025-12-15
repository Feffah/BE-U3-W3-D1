using System.ComponentModel.DataAnnotations;

namespace BE_U3_W3_D1.Models.Entities
{
    public class Student
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cognome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
