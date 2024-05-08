using System;
using System.Reflection;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car-DONE


            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable- DONE

            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-DONE


            //The methods should take one string parameter: the respective noise property -DONE



            //Now that the Car class is created we can instanciate 3 new cars- DONE
            //Set the properties for each of the cars-DONE

            CarLot davesCarlot = new CarLot();

            Car cydCar = new Car(2020,"Audi", "A3", "too loud", "level 2", true);

            davesCarlot.CarList.Add(cydCar);

            Car blakeCar = new Car()
            {
                Year = 2017,
                Make = "Nissan",
                Model = "Altima",
                EngineNoise = "not loud enough",
                HonkNoise = "level 1",
                IsDriveable = true
            };

            davesCarlot.CarList.Add(blakeCar);
          
            Car kateCar = new Car();
            kateCar.Year = 2019;
            kateCar.Make = "Lexus";
            kateCar.Model = "ES350";
            kateCar.EngineNoise = "loud";
            kateCar.HonkNoise = "level 3";
            kateCar.IsDriveable = false;

            davesCarlot.CarList.Add(kateCar);
            //Call each of the methods for each car -DONE

            cydCar.MakeEngineNoise(cydCar.EngineNoise);
            cydCar.MakeHonkNoise(cydCar.HonkNoise);

            blakeCar.MakeEngineNoise(blakeCar.EngineNoise);
            blakeCar.MakeHonkNoise(blakeCar.HonkNoise);

            kateCar.MakeEngineNoise(kateCar.EngineNoise);
            kateCar.MakeHonkNoise(kateCar.HonkNoise);

            Console.WriteLine($"Here are the details about the cars we have: "
);
            foreach (var car in davesCarlot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Model} Model: {car.Make}");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car  -DONE

            //*************BONUS X 2*************//

            //Create a CarLot class -DONE

            //It should have at least one property: a List of cars -DONE

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.-DONE

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console-DONE
        }
    }
}
