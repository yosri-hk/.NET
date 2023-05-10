using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Intefaces
{
   public interface IServiceFlight:IServices<Flight>

    {
        
        List<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);

        void showFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        public double DurationAverge(string destination);

        public IEnumerable<Flight> OrderedDurationFlights();
      //  public IEnumerable<Passenger> SeniorTravellers(Flight flight);
        public void DestinationGroupedFlights();
        public void Add(Flight flight);
        public IEnumerable<Flight> GetAll();
        public void Update(Flight flight);
        public void Remove(Flight flight);

    }
}
