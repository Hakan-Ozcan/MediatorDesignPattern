using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class Runway
    {
        public int RunwayNumber { get; private set; }
        private IAirTrafficControlMediator mediator;

        public Runway(int runwayNumber, IAirTrafficControlMediator mediator)
        {
            RunwayNumber = runwayNumber;
            this.mediator = mediator;
        }

        public void AcceptRequest(Airplane airplane)
        {
            Console.WriteLine($"Runway {RunwayNumber} is cleared for landing. Flight {airplane.FlightNumber} is landing.");
        }
    }
}
