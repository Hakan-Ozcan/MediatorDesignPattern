using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class FlightControlCenter : IAirTrafficControlMediator
    {
        private List<Airplane> airplanes;
        private List<Runway> runways;

        public FlightControlCenter()
        {
            airplanes = new List<Airplane>();
            runways = new List<Runway>();
        }

        public void RegisterAirplane(Airplane airplane)
        {
            airplanes.Add(airplane);
        }

        public void RegisterRunway(Runway runway)
        {
            runways.Add(runway);
        }

        public void Notify(Airplane airplane, string message)
        {
            Console.WriteLine($"[Air Traffic Control] {message}");
        }

        public void RequestLanding(Airplane airplane)
        {
            if (runways.Count > 0)
            {
                var runway = runways[0];
                runway.AcceptRequest(airplane);
                runways.RemoveAt(0);
            }
            else
            {
                Console.WriteLine($"No available runways. Flight {airplane.FlightNumber} has to wait.");
            }
        }
    }
}
