using RejestrKontroli.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RejestrKontroli.DAL
{
    public class RejestrContext: DbContext
    {
        public RejestrContext(): base("connectionstring")
        {

        }
        public DbSet<RejestrModel> Rejestr { get; set; }



    }
}