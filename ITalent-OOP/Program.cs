using ITalent_OOP;
using ITalent_OOP.Enums;




var vehicle1 = new AirPlane(AirPlaneTypes.Cargo);

vehicle1.yearEventOuterBounds += (year) => { Console.WriteLine($"Girilen {year} yılı istenilen aralıklarda değil"); };
vehicle1.yearEventValueChanged += (year) => { Console.WriteLine($"Araç yılı {year} olarak değiştirildi"); };


vehicle1.year = 1990;
vehicle1.fuelType = FuelTypes.Diesel;
vehicle1.SpeedIncrease(5);
vehicle1.year = 2020;

ILandVehicle vehicle2 = new Car();
vehicle2.Shift(5);
((Car)vehicle2).year = 2005;
((Car)vehicle2).carType = CarTypes.Coupe;
((Car)vehicle2).carMake = CarMakes.Fiat;

Console.WriteLine(((Car)vehicle2).ToString());


vehicle2 = new MotorCycle();
((MotorCycle)vehicle2).motorcycleType = MotorCycleTypes.Racing;




