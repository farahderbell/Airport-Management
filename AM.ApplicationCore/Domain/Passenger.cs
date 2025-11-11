using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }

        public ICollection<Flight> Flights { get; set; }


        public override string ToString()
        {
                       return $"Passenger ID: {Id}, Name: {FirstName} {LastName}, Email: {EmailAddress}, Phone: {PhoneNumber}, BirthDate: {BirthDate.ToShortDateString()}, PassportNumber: {PassportNumber}";
        }

       /* public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }
        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return FirstName == firstName && LastName == lastName && EmailAddress == email;
        }   */
       public bool CheckProfile(string firstName, string lastName, string? email = null)
       {
           if (email == null)
           {
               return FirstName == firstName && LastName == lastName;
           }
           else
           {
               return FirstName == firstName && LastName == lastName && EmailAddress == email;
           }
        }   
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }


    }
  
}
