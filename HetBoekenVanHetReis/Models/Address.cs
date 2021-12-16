using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetBoekenVanHetReis.Models
{
    public class Address
    {
        private int postcode;
        public string Straat { get; set; }
        public string HuisNummer { get; set; }
        public int Postcode {
            get {return Postcode; }
            set { postcode = value; } 
        }
        public string Gemeente { get; set; }
    }
}
