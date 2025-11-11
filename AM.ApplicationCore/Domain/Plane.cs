using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
       
        public enum PlaneType
        {
            Boing,
            Airbus,
           
        }   

        public int Capacity { get; set; }
        public int PlaneID { get; set; }
        public PlaneType Type { get; set; } 
        public DateTime ManufactureDate { get; set; }

        public ICollection<Flight> Flights { get; set; }
        public Plane MyPlane { get; set; }

        public override string ToString()
        {
            return $"PlaneID: {PlaneID}, Type: {Type}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate.ToShortDateString()}";
        }
        public Plane(int planeId,int capacity, DateTime ManufactureDate, PlaneType type)
        {
            this.PlaneID = planeId;
            this.Capacity = capacity;
            this.ManufactureDate = ManufactureDate;
            this.Type = type;


        }
        
        }



    }

