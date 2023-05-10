using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string? Destination { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        //[ForeignKey("PlaneId")]
        public virtual Plane Plane { get; set; }
        public string? AireLine { get; set; }
        [ForeignKey("Plane")]
        public int PlaneId { get; set; }
        // public ICollection<Passenger> Passengers { get; set; }
        public virtual List<Ticket> Tickets { get; set; }

        public override string ToString()
        {
            return "FlightId:" + FlightId + "FlightDate:" + FlightDate;

        }









    }
}
