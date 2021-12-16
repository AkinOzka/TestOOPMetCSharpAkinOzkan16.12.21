using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetBoekenVanHetReis
{
    public class Cruise:Reis
    {
        private const double CruisePrijsExtraDagKost = 10;

        public Cruise(DateTime terugDatum, DateTime vertrekDatum, int aantalPersonen) : base(terugDatum, vertrekDatum, aantalPersonen)
        {
        }

        public bool Vip { get; set; }
        public override double BerekenPrijs()
        {
            if (!Vip)
            {
                return CruisePrijsExtraDagKost;
            }
            else
            {
                return CruisePrijsExtraDagKost * 1.5;
            }
        }

    }
}
