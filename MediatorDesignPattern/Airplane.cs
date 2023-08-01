using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class Airplane
    {
        public int FlightNumber { get; private set; }
        public int Altitude { get; private set; }
        private IAirTrafficControlMediator mediator;

        public Airplane(int flightNumber, IAirTrafficControlMediator mediator)
        {
            FlightNumber = flightNumber;
            Altitude = 0;
            this.mediator = mediator;
        }

        public void Climb(int altitude)
        {
            Altitude += altitude;
            mediator.Notify(this, $"Flight {FlightNumber} is climbing to altitude {Altitude} feet.");
        }

        public void Descend(int altitude)
        {
            Altitude -= altitude;
            mediator.Notify(this, $"Flight {FlightNumber} is descending to altitude {Altitude} feet.");
        }

        public void RequestLanding()
        {
            mediator.RequestLanding(this);
        }
    }
}
