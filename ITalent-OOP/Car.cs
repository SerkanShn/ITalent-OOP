using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITalent_OOP.Enums;

namespace ITalent_OOP
{
    internal class Car
    {
        private int _year;
        private CarMakes _make;
        private int _horsePower;
        private FuelTypes _fuelType;
        private FuelTypes _type;

        public int year 
        {
            get { return _year; }
            set 
            {
                if (value < 1886 || value > 2022)
                    return;
                _year = value;
            }
        }

        public int horsepower
        {
            get { return _horsePower; }
            set
            {
                if (value < 0)
                    return;
                _horsePower = value;
            }
        }

        public CarMakes make { get; set; }
        public FuelTypes fuelType { get; set; }
        public CarTypes type { get; set; }


    }
}
