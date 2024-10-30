// Namnrymden för gränssnittet som används i detta projekt
using VehicleDemoMenu.Interfaces;

namespace VehicleDemoMenu.Delegates
{
    // Definierar en delegerad typ som heter "VehicleDelegate"
    // VehicleDelegate representerar en metod som inte tar några argument 
    // och som returnerar ett objekt av typen IVehicle.
    // Används för att dynamiskt kunna tilldela olika metoder till denna delegate
    // som returnerar olika typer av fordon
    // (t.ex. Car, Bus, Formula1Car).
    public delegate IVehicle VehicleDelegate();
}
