using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [Display(Name ="Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }
        public string? EmailAdress { get; set; }
        public FullName Fullname { get; set; }
        //[MinLength(3,ErrorMessage ="Longueur minimale 3")]
        //[MaxLength(25,ErrorMessage="Longueur maximale 25")]
        // public string FirstName { get; set; }
        // public string LastName { get; set; }
        [RegularExpression(@"^[0-9]{8}$")]
        public int TelNumber { get; set; }

       // public ICollection<Flight> Flights { get; set; }
        //public int PassengerId { get; set; }
        public  virtual List<Ticket> Tickets { get; set; }

        public override string ToString()
        {
            return "FirstName" + Fullname.FirstName + "LastName" + Fullname.LastName + "Date of birth" + BirthDate;

        }

        //// public bool CheckProfile( string nom,string prenom)
        // {
        //     return nom==LastName && prenom==FirstName;
        // }

        // public bool CheckProfile(string nom, string prenom,string mail)
        // {
        //     return LastName == nom && FirstName== prenom && EmailAdress==mail;
        // }

        public bool CheckProfile(string nom, string prenom, string mail = null)
        {
            if (mail == null)
            {


                return nom == Fullname.LastName && prenom == Fullname.FirstName;
            }


            else
                return Fullname.LastName == nom && Fullname.FirstName == prenom && EmailAdress == mail;

        }



        public virtual void PassengerType()
        {

            Console.WriteLine("i am a passenger");
        }


    }
}