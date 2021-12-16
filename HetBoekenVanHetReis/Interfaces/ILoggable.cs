using HetBoekenVanHetReis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetBoekenVanHetReis.Interfaces
{
    interface ILoggable
    {
        LogMessage LogMessage{get;}
    }
}
