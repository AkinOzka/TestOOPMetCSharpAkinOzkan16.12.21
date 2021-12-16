using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetBoekenVanHetReis
{
    public abstract class Reis
    {
        public Reis(DateTime terugDatum, DateTime vertrekDatum, int aantalPersonen)
        {
            TerugkeerDatum = terugDatum;
            VertrekDatum = vertrekDatum;
            AantalPersonen = aantalPersonen;
        }
        private const double BasisDagPrijs = 40;
        private int AantalPersonen { get; set; }
        private DateTime VertrekDatum
        { 
            get { return VertrekDatum; }
            set
            {
                if (VertrekDatum>DateTime.Now)
                {
                    throw new Exception("Datum kan niet in de verleden zijn");
                }
            VertrekDatum=value;
            }
        }
        private DateTime TerugkeerDatum
        {
            get { return TerugkeerDatum; }
            set 
            {
                if (AantalDagen<=0)
                {
                    throw new Exception("U kan de dezelfde dag niet kiezen. U moet minstens 1 dag blijven");
                }
                TerugkeerDatum=value;
            }
        }       
        public int AantalDagen
        {         
            get
            { 
                TimeSpan ts = TerugkeerDatum - VertrekDatum;
                return ts.Days;
            }           
        }
        public virtual double BerekenPrijs()
        {
            return BasisDagPrijs * AantalDagen;
        }    
    }
}
