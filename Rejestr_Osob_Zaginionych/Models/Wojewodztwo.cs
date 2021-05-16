using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rejestr_Osob_Zaginionych.Models
{
    public class Wojewodztwo
    {
        public int Id { get; set; }

        [Display(Name = "Województwo")]
        public string Name { get; set; }
    }
}