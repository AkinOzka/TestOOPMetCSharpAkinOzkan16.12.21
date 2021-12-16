using HetBoekenVanHetReis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetBoekenVanHetReis.Models
{
    public class ReisReservatie : ILoggable
    {
        public ReisReservatie(Reis reis, ReisBureau reisBureau, Persoon persoon)
        {
            Reis = reis;
            ReisBureau = reisBureau;
            Persoon = persoon;
            LoggerService.AddLogMessage(LogMessage);
        }
        public Reis Reis  { get; set; }
        public ReisBureau ReisBureau { get; set; }
        public Persoon Persoon { get; set; }
        public LogMessage LogMessage => throw new NotImplementedException();
        public LogMessage LogMessage
        {
            get
            {
                return new LogMessage($"Reis gereserveerd door {Persoon.Naam} via reisbureau");
            }
        }
    }
}
