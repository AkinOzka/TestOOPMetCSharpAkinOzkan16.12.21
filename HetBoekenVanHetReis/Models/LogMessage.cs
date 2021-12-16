using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetBoekenVanHetReis.Models
{
    public class LogMessage
    {
        private string _Boodschap { get; set; }
        private int _Id { get; set; }
        public string V { get; }

        public LogMessage(string Boodschap, int Id)
        {
            _Id = Id;
            _Boodschap = Boodschap;
        }

        public LogMessage(string v)
        {
            V = v;
        }

        public int GenereerId()
        {
            return _Id;
        }
    }
}
