using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetBoekenVanHetReis.Models
{
    public class AutoVakantie:Reis
    {
        private const double ExtraPrijsHuurAuto = 10;

        public AutoVakantie(DateTime terugDatum, DateTime vertrekDatum, int aantalPersonen) : base(terugDatum, vertrekDatum, aantalPersonen)
        {
        }

        private bool EigenWagen { get; set; }
        public override double BerekenPrijs()
        {
            if (!EigenWagen)
            {
                return ExtraPrijsHuurAuto * AantalDagen;
            }
            else
            {
                return 0;
            }
                   
        }

    }
}
