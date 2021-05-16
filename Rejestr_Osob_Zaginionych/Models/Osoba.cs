using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rejestr_Osob_Zaginionych.Models
{
    public class Osoba
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Imię jest wymagane")]
        [StringLength(50)]
        public string Imię { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [StringLength(50)]
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        [Required(ErrorMessage = "Płeć jest wymagana")]
        [StringLength(50)]
        public string Płeć { get; set; }
        [Required(ErrorMessage = "Ostatnie miejsce pobytu jest wymagane")]
        [StringLength(50)]
        [Display(Name = "Ostatnie miejsce pobytu")]
        public string Ostatnie_miejsce_pobytu { get; set; }

        // Foregin Key
        [Display(Name = "Województwo")]
        public int WojewodztwoId { get; set; }

        public Wojewodztwo Wojewodztwo { get; set; }
    }
}