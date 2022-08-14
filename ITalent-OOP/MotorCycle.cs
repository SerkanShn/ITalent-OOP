using ITalent_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_OOP
{
    internal class MotorCycle : Vehicle, ILandVehicle
    {
        public MotorCycleTypes motorcycleType;
        public int shift { get; set ; }

        public void Horn()
        {
            Console.WriteLine("Kornaya Basıldı (Motor)");
        }

        public void Shift(int shiftValue)
        {
            shift = shiftValue;
            Console.WriteLine("Vites Değiştirildi (Motor) Vites : " + shiftValue);
        }

        public override void SpeedIncrease(int value)
        {
            speed = value * 3;
            Console.WriteLine("Hız Arttırıldı (Araba)");
        }

    }
}
