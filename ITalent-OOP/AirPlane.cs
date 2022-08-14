using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITalent_OOP.Enums;

namespace ITalent_OOP
{
    internal class AirPlane : Vehicle
    {


        private AirPlaneTypes _airplaneType;

        public AirPlaneTypes airplaneType { get; set; }

        public AirPlane()
        {

        }

        public AirPlane(AirPlaneTypes airplaneType)
        {
            _airplaneType = airplaneType;
        }

        public void LandOff()
        {
            Console.WriteLine("Uçak Havalandı");
        }

        public void LandOn()
        {
            Console.WriteLine("Uçak İniş Yaptı");
        }

        public override void SpeedIncrease(int value)
        {
            speed = value*2;
            Console.WriteLine("Hız Arttırıldı (Hava Taşıtı)");
        }

    }
}
