using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight

    {

        public string  Departure { get; set; }
        public string  Destination { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightID { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return $"FlightID: {FlightID}, From: {Departure} To: {Destination}, Duration: {EstimatedDuration} mins, FlightDate: {FlightDate.ToShortDateString()}, EffectiveArrival: {EffectiveArrival.ToShortDateString()}";
        }   
    }
}
