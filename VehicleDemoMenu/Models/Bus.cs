using VehicleDemoMenu.Interfaces;

namespace VehicleDemoMenu.Models
{
    public class Bus : IVehicle
    {
        public string Drive()
        {
            return "Driving a bus!";
        }

        // Alternativt sätt att skriva metoden Drive med en lambda-uttryck:
        // Lambda-uttrycket gör metoden kortare och fungerar likadant
        // public string Drive() => "Driving a bus!";
    }
}
