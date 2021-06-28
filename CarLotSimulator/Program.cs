using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLotClass lot = new CarLotClass();
            
            
            
            Car toyota = new Car();
            lot.Cars.Add(toyota);
            
           
            toyota.Year = 2020;
            toyota.Make = "Camry";
            toyota.Model = "LE";
            toyota.EngineNoise = "Whoosh";
            toyota.HonkNoise = "Meep Meep";
            toyota.IsDriveable = true;

            toyota.MakeEngineNoise(toyota.EngineNoise);
            toyota.MakeHonkNoise(toyota.HonkNoise);



            Car honda = new Car() { Year = 2014, Make = "Civic", Model = "Coupe", EngineNoise = "Vroom", HonkNoise = "Boop Boop"};
            lot.Cars.Add(honda);
            
            honda.MakeEngineNoise(honda.EngineNoise);
            honda.MakeHonkNoise(honda.HonkNoise);



            Car acura = new Car(2002, "TL", "Type-S", "Dash", "Pow Pow", true);
            lot.Cars.Add(acura);
           
            acura.MakeEngineNoise(acura.EngineNoise);
            acura.MakeHonkNoise(acura.HonkNoise);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
               
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
                
            }

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
