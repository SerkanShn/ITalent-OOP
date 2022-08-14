using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITalent_OOP.Enums;

namespace ITalent_OOP
{
    internal class Vehicle
    {
        private int _year;
        private int _horsePower;
        public FuelTypes fuelType;
        public int speed;

        public event Action<int> yearEventOuterBounds;
        public event Action<int> yearEventValueChanged;
        public int year 
        {
            get { return _year; }
            set 
            {
                if (value < 2000 || value > 2022)
                {
                    if (yearEventOuterBounds != null)
                        yearEventOuterBounds(value);
                }
                else
                {
                    if (yearEventValueChanged != null)
                        yearEventValueChanged(value);
                    _year = value;
                }
            }
        }

        public int horsepower
        {
            get { return _horsePower; }
            set
            {
                if (value < 0)
                    return;
                else
                    _horsePower = value;
            }
        }

        public Vehicle(){}
        public Vehicle(int year)
        {
            _year = year;
        }

        public Vehicle(int year, int horsePower) : this(year)
        {
            _horsePower = horsePower;
        }

        public Vehicle(int year, int horsePower, FuelTypes fuelType) : this(year,horsePower)
        {
            this.fuelType = fuelType;
        }

        public virtual void SpeedIncrease(int value)
        {
            speed = value;
            Console.WriteLine("Hız Arttırıldı");
        }

        

    }
}
