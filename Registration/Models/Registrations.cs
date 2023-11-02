using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class Registrations
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Podane hasla nie sa takie same")]
        public string ConfirmPassword { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Miasto { get; set; }

    } 
}
