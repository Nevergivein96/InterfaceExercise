using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public double CargoHoldSize { get; set; } = 25;

        public bool HasAWD { get; set; } = true;
        public double EngineSize { get; set; } = 3.5;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Explorer";
        public int SeatCount { get; set; } = 6;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford tough";
        public bool HasChangedGears { get; set; }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            if (HasAWD == true)
            {
                Console.WriteLine($"AWD Now engaged and {GetType().Name} is now driving forward");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward");
            }
          
        }

        public void Park()
        {

            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("cant park until we change gears");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving in reverse");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("cant reverse until we change gears");
            }
        }


    }
}
