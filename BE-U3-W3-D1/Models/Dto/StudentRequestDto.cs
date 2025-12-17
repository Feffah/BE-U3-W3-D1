using System.ComponentModel.DataAnnotations;

namespace BE_U3_W3_D1.Models.Dto
{
    public class StudentRequestDto
    {
        [Required]
        public Guid Id { get; set; }

        public string? Nome { get; set; }


        public string? Cognome { get; set; }


        public string? Email { get; set; }
    }
}
