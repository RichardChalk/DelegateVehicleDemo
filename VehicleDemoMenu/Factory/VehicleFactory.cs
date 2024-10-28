using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleDemoMenu.Interfaces;
using VehicleDemoMenu.Models;

namespace VehicleDemoMenu.Factory
{
    public static class VehicleFactory
    {
        public static IVehicle CreateCar()
        {
            return new Car();
        }

        public static IVehicle CreateBus()
        {
            return new Bus();
        }

        public static IVehicle CreateFormula1Car()
        {
            return new Formula1Car();
        }
    }
}
