using System;
using System.ComponentModel.DataAnnotations;

namespace ATM_CLONE_APP.Models
{
    public class UserModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Username cannot be longer than 10 characters ")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Password must be between 6 and 10 characters ")]
        public string Password { get; set; }

    }
}