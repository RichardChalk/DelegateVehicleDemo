using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleDemoMenu.Interfaces;

namespace VehicleDemoMenu.Models
{
    public class Formula1Car : IVehicle
    {
        public string Drive()
        {
            return "Racing a Formula 1 car!";
        }

        // Man kan göra samma sak med en Lmnda expression!
        // public string Drive() => "Driving a Formula 1 car!";
    }
}
