using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetBoekenVanHetReis.Models
{
    public class VliegtuigVakantie:Reis
    {
        private readonly double _VliegtuigTicketPrijs;
        public VliegtuigVakantie(double VliegtuigTicketPrijs)
        {
            _VliegtuigTicketPrijs=VliegtuigTicketPrijs;
        }
       public double VliegtuigTicketPrijs { get { return _VliegtuigTicketPrijs ;}  }
        public override double BerekenPrijs()
        {
            return base.BerekenPrijs();
        }
    }
}
