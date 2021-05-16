using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rejestr_Osob_Zaginionych.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Osoba> Osobas { get; set; }
        public DbSet<Wojewodztwo> Wojewodztwos { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}