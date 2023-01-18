using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public Double TrunkSpace { get; set; } = 9.0;
        public bool RunsAndDrives { get; set; } = true;
        public double EngineSize { get; set; } = 5.0;
        public string Make { get; set; } = "Ford";
        public string Model { get ; set ; } = "Mustang";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford tough";
        public bool HasChangedGears { get ; set ; }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears= isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward");
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
                HasChangedGears= false;
            }
            else
            {
                Console.WriteLine("cant reverse until we change gears");            
            }
        }
    }
}
