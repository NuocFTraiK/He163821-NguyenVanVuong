using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2
{   
    class Battery
    {
        int energy;

        public Battery()
        {
            this.energy = 10;
        }

        public Battery(int energy)
        {
            this.Energy = energy;
        }

        public int Energy { get => energy; set => energy = value; }

        public void decreaseEnergy()
        {
            this.energy -= 2;
        }
    }

    class FlashLamp
    {
        bool status;
        Battery battery;

        public FlashLamp()
        {

        }

        public FlashLamp(bool status, Battery battery)
        {
            this.Status = status;
            this.Battery = battery;
        }

        public bool Status { get => status; set => status = value; }
        internal Battery Battery { get => battery; set => battery = value; }

        public void turnOn() {
            if (battery.Energy > 0)
            {
                status = true;
                Console.WriteLine("Den sang");
                battery.decreaseEnergy();
            }
        }
        public void turnOff()
        {
            this.status = false;
            Console.WriteLine("Den tat");
        }

        public int getBatteryInfo()
        {
            return battery.Energy;
        }
    }

    class TestFlashLamp
    {
        static void Main(string[] args)
        {
            Battery b = new Battery();
            FlashLamp f = new FlashLamp();

            f.Battery = b;
            for (int i = 0; i < 5; i++)
            {

                f.turnOn();
                f.turnOff();
                if (f.getBatteryInfo() == 0)
                {
                    Console.WriteLine("Het pin");
                    break;
                }
            }
            Console.WriteLine($"Energy: {f.getBatteryInfo()}");

        }


    }
    internal class Program2_Bai16
    {
    }
}
