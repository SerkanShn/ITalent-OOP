using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITalent_OOP.Enums;

namespace ITalent_OOP
{
    internal class Car : Vehicle , ILandVehicle
    {
        public CarMakes carMake { get; set; }
        public CarTypes carType { get; set; }
        public int shift { get; set; }

        public Car()
        {

        }
        public Car(CarMakes carMake) 
        {
            carMake = carMake;
        }

        public Car(CarMakes carMake, CarTypes carType) : this(carMake)
        {
            carType = carType;
        }

        public Car(CarMakes carMake,CarTypes carType,int shift):this(carMake,carType)
        {
            shift = shift;
        }

        public void Horn()
        {
            Console.WriteLine("Kornaya Basıldı (Araba)");
        }

        public void Shift(int shiftValue)
        {
            shift = shiftValue;
            Console.WriteLine("Vites Değiştirildi (Araba) Vites : " + shiftValue);
        }

        public override void SpeedIncrease(int value)
        {
            speed = value * 3;
            Console.WriteLine("Hız Arttırıldı (Araba)");
        }

        public override string ToString()
        {
            return $"Yıl {year} + Yakıt Türü {fuelType} + Markası {carMake}";
        }

    }
}
