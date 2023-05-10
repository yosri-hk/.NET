using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static Plane Plane_1 = new Plane
        {
            PlaneType = PlaneType.Boeing,
            Capacity = 150,
            ManufactureDate = new DateTime(2015, 02, 03)
        };

        public static Plane Plane_2 = new Plane
        {
            PlaneType = PlaneType.Airbus,
            Capacity = 250,
            ManufactureDate = new DateTime(2020, 11, 11)
        };

        public static Staff staff_1 = new Staff
        {
            Fullname = new FullName { FirstName = "captain", LastName = "captain" },
            EmailAdress = "Captain.captain@gmail.com",
            BirthDate = new DateTime(1965, 01, 01),
            EmploymentDate = new DateTime(1999, 01, 01),
            Salary = 99999
        };

        public static Staff staff_2 = new Staff
        {
            Fullname = new FullName { FirstName = "hotess1", LastName = "hotess1" },

            EmailAdress = "hostess1.hostess1@gmail.com",
            BirthDate = new DateTime(1995, 01, 01),
            EmploymentDate = new DateTime(2020, 01, 01),
            Salary = 999
        };

        public static Staff staff_3 = new Staff
        {
            Fullname = new FullName { FirstName = "hotess2", LastName = "hotess2" },
            EmailAdress = "hostess2.hostess2@gmail.com",
            BirthDate = new DateTime(1996, 01, 01),
            EmploymentDate = new DateTime(2020, 01, 01),
            Salary = 999
        };

        public static Traveller traveller_1 = new Traveller
        {
            Fullname = new FullName { FirstName = "Traveller1", LastName = "Traveller1" },
            EmailAdress = "traveller1.traveller1@gmail.com",
            BirthDate = new DateTime(1980, 01, 01),
            HealthInformation = "No trouble",
            Nationality = "American"
        };

        public static Traveller traveller_2 = new Traveller
        {
            Fullname = new FullName { FirstName = "Traveller2", LastName = "Traveller2" },
            EmailAdress = "traveller2.traveller2@gmail.com",
            BirthDate = new DateTime(1981, 01, 01),
            HealthInformation = "Some troubles",
            Nationality = "French"
        };

        public static Traveller traveller_3 = new Traveller
        {
            Fullname = new FullName { FirstName = "Traveller3", LastName = "Traveller3" },
            EmailAdress = "traveller3.traveller3@gmail.com",
            BirthDate = new DateTime(1982, 01, 01),
            HealthInformation = "No trouble",
            Nationality = "Tunisian"
        };

        public static Traveller traveller_4 = new Traveller
        {
            Fullname = new FullName { FirstName = "Traveller4", LastName = "Traveller4" },
            EmailAdress = "traveller4.traveller4@gmail.com",
            BirthDate = new DateTime(1983, 01, 01),
            HealthInformation = "Some troubles",
            Nationality = "American"
        };

        public static Traveller traveller_5 = new Traveller
        {
            Fullname = new FullName { FirstName = "Traveller5", LastName = "Traveller5" },
            EmailAdress = "traveller5.traveller5@gmail.com",
            BirthDate = new DateTime(1984, 01, 01),
            HealthInformation = "Some troubles",
            Nationality = "Spanish"
        };

        public static Flight flight_1 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01, 15, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 01, 17, 10, 10),
            Plane = Plane_2,
            EstimatedDuration = 110,
            //Passengers = new List<Passenger> { traveller_1, traveller_2, traveller_3, traveller_4, traveller_5 }
        };

        public static Flight flight_2 = new Flight
        {
            FlightDate = new DateTime(2022, 02, 01, 23, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10),
            Plane = Plane_1,
            EstimatedDuration = 105
        };

        public static Flight flight_3 = new Flight
        {
            FlightDate = new DateTime(2022, 03, 01, 21, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 03, 01, 23, 10, 10),
            Plane = Plane_1,
            EstimatedDuration = 100
        };

        public static Flight flight_4 = new Flight
        {
            FlightDate = new DateTime(2022, 04, 01, 05, 10, 10),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 04, 01, 08, 10, 10),
            Plane = Plane_1,
            EstimatedDuration = 130
        };

        public static Flight flight_5 = new Flight
        {
            FlightDate = new DateTime(2022, 05, 01, 17, 10, 10),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 05, 01, 18, 10, 10),
            Plane = Plane_1,
            EstimatedDuration = 105
        };

        public static Flight flight_6 = new Flight
        {
            FlightDate = new DateTime(2022, 06, 01, 20, 10, 10),
            Destination = "Lisbonne",
            EffectiveArrival = new DateTime(2022, 06, 01, 22, 30, 10),
            Plane = Plane_2,
            EstimatedDuration = 200
        };

        public static List<Flight> listFlights = new List<Flight> { flight_1, flight_2, flight_3, flight_4, flight_5, flight_6 };


        





    }
}
