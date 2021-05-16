using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rejestr_Osob_Zaginionych.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="E-mail jest wymagany")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        [Display(Name ="Nazwa użytkownika")]
        [StringLength(50)]
        [MaxLength(50)]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [Display(Name = "Hasło")]
        [StringLength(20)]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public bool IsActive { get; set; }
    }
}