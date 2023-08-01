using MediatorDesignPattern;

public class Program
{
    public static void Main()
    {
        FlightControlCenter controlCenter = new FlightControlCenter();

        Airplane airplane1 = new Airplane(101, controlCenter);
        Airplane airplane2 = new Airplane(202, controlCenter);

        Runway runway1 = new Runway(1, controlCenter);
        Runway runway2 = new Runway(2, controlCenter);

        controlCenter.RegisterAirplane(airplane1);
        controlCenter.RegisterAirplane(airplane2);
        controlCenter.RegisterRunway(runway1);
        controlCenter.RegisterRunway(runway2);

        airplane1.Climb(30000);
        airplane2.Climb(28000);
        airplane1.RequestLanding();
        airplane2.RequestLanding();
    }
}