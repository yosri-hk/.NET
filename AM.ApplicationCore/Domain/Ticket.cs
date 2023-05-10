﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public int Prix { get; set; }
        public int Siege { get; set; }
        public bool Vip { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual Passenger Passenger { get; set; }
      //  [ForeignKey("Flight")]
        public int FlightId { get; set; }
       // [ForeignKey("Passenger")]
        public string PassengerId { get; set; }
    }
}
