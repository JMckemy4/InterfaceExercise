using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle , ICompany 
    {
        public bool CanOffRoad { get; set; }
        
        public string CanFitInGarage { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }
        public bool RunsWell { get; set; }
        public string HasWindows { get; set; }
        public string TravelsDistance { get; set; }
        public bool HasAnEngine { get; set; }
    }
}
