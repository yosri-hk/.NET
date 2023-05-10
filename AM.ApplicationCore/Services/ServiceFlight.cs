using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Intefaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight:Service<Flight>, IServiceFlight
    {
        IGenericRepository<Flight> _genericRepository;
        IUnitOfWork _unitofwork;
        public ServiceFlight(IUnitOfWork unitofwork) : base(unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public List<Flight> Flights => GetAll().ToList();
        public void DestinationGroupedFlights()
        {

            //var req = from f in Flights
            //          group f by f.Destination;
            //foreach (var g in req)
            //{
            //    Console.WriteLine("Destination : " + g.Key);
            //    foreach (var f in g)

            //        Console.WriteLine("decollage:" + f.FlightDate);
            //}



        }

       

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> result = new List<DateTime>();
            for (int i = 0; i < Flights.Count(); i++)
            {
                if (Flights[i].Destination.Equals(destination))
                {
                    result.Add(Flights[i].FlightDate);
                }
            }
            //7*
            //foreach (Flight f in Flights)
            //{
            //    if (f.Destination.Equals(destination))
            //    {
            //        result.Add(f.FlightDate);
            //    }

            //}
            return result;
            //  tp2-q9:
            //var query = from Flight in Flights
            //            where Flight.Destination.Equals(destination)
            //            select Flight.FlightDate;
            //return query.ToList();



        }
        //8*
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination == filterValue)
                        { System.Console.WriteLine(f); }

                    }
                    break;
                case "FlightDate":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightDate == DateTime.Parse(filterValue))
                        { System.Console.WriteLine(f); }

                    }
                    break;
                case "FlightId":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightId == int.Parse(filterValue))
                        { System.Console.WriteLine(f); }




                    }
                    break;

            }
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            //return (from Flight in Flights
            //        orderby Flight.EstimatedDuration descending
            //        select Flight);

            return (Flights.OrderByDescending(flight => flight.EstimatedDuration));
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            //var query = from Flight in Flights
            //            where (Flight.FlightDate -startDate).TotalDays < 8 && (Flight.FlightDate - startDate).TotalDays > 0
            //            select Flight;
            //return query.Count();


            var lambdaquery = Flights
            .Where(flight => (flight.FlightDate - startDate).TotalDays < 8
            && (flight.FlightDate - startDate).TotalDays > 0);
            return lambdaquery.Count();





        }

        //public IEnumerable<Passenger> SeniorTravellers(Flight flight)
        //{
        //    //return (from P in flight.Passengers.OfType<Traveller>() 
        //    //        orderby P.BirthDate ascending
        //    //        select P).Take(3);
        //    return (flight.Passengers.OfType<Traveller>()
        //        .OrderBy(p => p.BirthDate)).Take(3);

        //}

        
        

        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;
        //public ServiceFlight()
        //{
        //    //FlightDetailsDel = ShowFlightDetails;
        //    //DurationAverageDel = DurationAverage;
        //    FlightDetailsDel = p =>
        //    {
        //        var query = from Flight in Flights
        //                    where Flight.Plane.Equals(p)
        //                    select new
        //                    {
        //                        Flight.FlightDate,
        //                        Flight.Destination
        //                    };
        //        foreach (var v in query)
        //        {
        //            Console.WriteLine("la date:" + v.FlightDate + "La destination :" + v.Destination);
        //        }
        //    };
        //    DurationAverageDel = d =>
        //    {


        //        return (from flight in Flights
        //                where (flight.Destination.Equals(d))
        //                select flight.EstimatedDuration).Average();



        //    };






        //}

        public void Add(Flight flight)
        {
            _unitofwork.repository<Flight>().Add(flight);


        }

        public void Update(Flight flight)
        {
            _unitofwork.repository<Flight>().Update(flight);

        }

        public IEnumerable<Flight> GetAll()
        {
            return _unitofwork.repository<Flight>().GetAll();

        }
       

        public void showFlightDetails(Plane plane)
        {
            //var query = from Flight in Flights 
            //           where Flight.Plane.Equals(plane)
            //    select new
            //    {
            //        Flight.FlightDate,
            //        Flight.Destination
            //    };

            var lambdaquery = Flights
                 .Where(flight => flight.Plane.Equals(plane))
                 .Select(Flight => new { Flight.FlightDate, Flight.Destination });

            foreach (var v in lambdaquery)
            {
                Console.WriteLine("la date:" + v.FlightDate + "La destination :" + v.Destination);
            }
        }

        public double DurationAverge(string destination)
        {
            //return (from flight in Flights
            //        where (flight.Destination.Equals(destination))
            //        select flight.EstimatedDuration).Average();

            var lambdaquery = Flights
                .Where(Flight => Flight.Destination.Equals(destination))
                .Select(Flight => Flight.EstimatedDuration);
            return lambdaquery.Average();
        }

        public void Remove(Flight flight)
        {
            _unitofwork.repository<Flight>().Delete(flight);
        }
    }
}
