using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    //A class dto is like the ViewModel
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength = 4, ErrorMessage="You must specify a password between 4 and 8 charachters")]
        public string Password { get; set; }
    }
}