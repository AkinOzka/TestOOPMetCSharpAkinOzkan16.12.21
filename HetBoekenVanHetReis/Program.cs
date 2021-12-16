using HetBoekenVanHetReis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetBoekenVanHetReis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon persoon = new Persoon();
            persoon.Naam = "Akin";
            persoon.Familienaam = "Ozkan";
            persoon.Adres = "Tienen";

            Persoon persoon2 = new Persoon();
            persoon2.Naam = "Marc";
            persoon2.Familienaam = "Van Klussen";
            persoon2.Adres = "Brussel";
        }
    }
}
