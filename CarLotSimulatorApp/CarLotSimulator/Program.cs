using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            var car1 = new Car() { Make = "Ford", Model = "Mustang", Year = 1965, IsDriveable = true};
            var car2 = new Car();
            var car3 = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Year = 1972,
                IsDriveable = true,
            };

            car2.Make = "Chevorlet";
            car2.Model = "Corvette";
            car2.Year = 1953;
            car2.IsDriveable = true;

            carLot.Cars = new List<Car>();
            carLot.Cars.Add(car1);
            carLot.Cars.Add(car2);
            carLot.Cars.Add(car3);

            foreach (var car in carLot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
