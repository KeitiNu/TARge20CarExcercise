using System;

namespace CarExercise
{
    class Program
    {
        static void Main(string[] args) 

        {
            Car auto = new Car("Renault", "Clio", "291THB", "red");
            auto.PrintCarInfo();

            if (auto.FuelTank > 0)
            {
                while (auto.FuelTank > 0)
                {
                    auto.DriveCar();
                    //auto.PrintCarInfo();//võib aktiveerida, et kontrollida toimimist
                }
                Console.WriteLine("The race is over!");
                auto.PrintCarInfo();
            }

        }
    }
}
