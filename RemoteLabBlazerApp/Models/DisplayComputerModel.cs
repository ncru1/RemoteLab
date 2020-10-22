using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteLabBlazerApp.Models
{
    public class DisplayComputerModel
    { 
        public string FQDN { get; set; }

        public string RDPStatus { get; set; }
    }
}
