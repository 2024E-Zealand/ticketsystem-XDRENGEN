
namespace TicketClassLibrary
{
    public interface IVehicle
    {
        bool BroBizzUsed { get; set; }
        DateTime Date { get; set; }
        string Licenseplate { get; set; }

        double Price();
        double PriceWithDiscount();
        string VehicleType();
    }
}