using Rejestr_Osob_Zaginionych.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rejestr_Osob_Zaginionych.ViewModels
{
    public class OsobaFromViewModel
    {
        public Osoba Osoba { get; set; }

        public IEnumerable<Wojewodztwo> Wojewodztwos { get; set; }

    }
}