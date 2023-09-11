using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle : ICompany
    {
        public bool RunsWell { get; set; }

        public string HasWindows { get; set; }

        public string TravelsDistance { get; set; }

        public bool HasAnEngine { get; set; }


    }
}
