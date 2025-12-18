namespace BE_U3_W3_D1.Models.Dto
{

        public class LoginResponseDto
        {
            public string Token { get; set; }
            public DateTime Expiration { get; set; }
        }
    }