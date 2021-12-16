using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetBoekenVanHetReis.Models
{
    public class Persoon
    {
        public string Naam
        {
            set { Naam = value; }
        }
        public string Familienaam { get; set; }
        public string Voornaam { get; set; }
        public string Adres { get; set; }
    }
}
