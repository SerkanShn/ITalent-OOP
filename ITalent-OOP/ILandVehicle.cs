using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_OOP
{
    internal interface ILandVehicle
    {
        public int shift { get; set; }
        void Horn();
        void Shift(int shiftValue);
    }
}
