// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

Console.WriteLine("Hello, World!");

Plane plane1 = new Plane();
plane1.Capacity = 500;
plane1.ManufactureDate = DateTime.Now;
plane1.PlaneType=PlaneType.Boeing;

//Plane plane2 = new Plane(PlaneType.Airbus,400,DateTime.Now);
//initiateur d'objet
Plane plane3 = new Plane
{
    Capacity = 500,ManufactureDate = new DateTime(2022,09,22),PlaneType=PlaneType.Airbus,
};

//Console.WriteLine(plane1.ToString());
//ServiceFlight sf = new ServiceFlight();
//sf.Flights = TestData.listFlights;

//Console.WriteLine("flight dates to madrid");
//foreach (var item in sf.GetFlightDates("Madrid"))
//    Console.WriteLine(item);

//Console.WriteLine("flights");
//sf.GetFlights("Destination", "Paris");

//Console.WriteLine("les details du vol de l'avion Airebus");
//sf.showFlightDetails(TestData.Plane_2);

//Console.WriteLine("les vols programmés pour ces 7 jours");
//Console.WriteLine(sf.ProgrammedFlightNumber(new DateTime(2021,12,30)));
//Console.WriteLine("la durée estimée des vols");
//Console.WriteLine(sf.DurationAverge("Lisbonne"));
//Console.WriteLine("la liste des vols ordonneee");

//foreach (var item in sf.OrderedDurationFlights())
//{


//    Console.WriteLine(item);

//}

//foreach (var item in sf.SeniorTravellers(TestData.flight_1))
//{


//    Console.WriteLine(item);

//}
//sf.DestinationGroupedFlights();


//sf.FlightDetailsDel(TestData.Plane_1);
//Console.WriteLine("la durree " + sf.DurationAverageDel("Paris"));
Traveller t1=TestData.traveller_1;
t1.UpperFullName();
Console.WriteLine(t1.Fullname.FirstName);
Console.WriteLine(t1.Fullname.LastName);


AMContext context = new AMContext();
//context.Flights.Add(TestData.flight_1);
//context.SaveChanges();

Console.WriteLine(context.Flights.First().Plane.Capacity);