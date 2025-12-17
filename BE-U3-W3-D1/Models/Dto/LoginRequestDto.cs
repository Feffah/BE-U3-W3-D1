using System.ComponentModel.DataAnnotations;

namespace BE_U3_W3_D1.Models.Dto
{
    public class LoginRequestDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
