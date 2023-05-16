using CarsLab;
using System.Diagnostics;
using System.Linq;
	

UsedCar jeepCherokee95 = new UsedCar("Jeep", "Cherokee", 1995, 2000.01, 174505 );
UsedCar chevyCorsica95 = new UsedCar("Chevy", "Corsica", 1995, 1350.01, 199000);
UsedCar fordFiest94 = new UsedCar("Ford", "Fiesta", 1994, 52.01, 250999);
Car kiaRio23 = new Car("Kia", "Rio", 2023, 17500.01);
Car kiaForte23 = new Car("Kia", "Forte", 2023, 20500.01);
Car hondaCivic23 = new Car("Honda", "Civic", 2023, 25000.01);


Car.CarsList.Add(jeepCherokee95);
Car.CarsList.Add(chevyCorsica95);
Car.CarsList.Add(fordFiest94);
Car.CarsList.Add(kiaRio23);
Car.CarsList.Add(kiaForte23);
Car.CarsList.Add(hondaCivic23);

int input = -1;
bool isDoneShopping = false;

do
{
	tryAgain: 

    Car.ListCars(Car.CarsList);
    Console.WriteLine("Which car would you like? (please order by number)");

    while (true)
	{		
		try
		{
			input = int.Parse(Console.ReadLine());
			break;

		}
		catch (FormatException x)
		{
			Console.WriteLine($"That is not a valid entry, please order by the numbers provided. {x.Message}");
			goto tryAgain;
		}
	} 
	while (true) 
	{
		try
		{
            Console.WriteLine(Car.CarsList.ElementAt(input).ToString());
			break;
        }
		catch (ArgumentOutOfRangeException x)
		{
            Console.WriteLine($"That number does not correspond with any of our vehicles. {x.Message}");
			goto tryAgain;
        }
	}
    Console.WriteLine("Such a cool car. Thank you, our Finance Department will be in touch with you shortly.");
    Car.Remove(input, Car.CarsList);
    Console.WriteLine("Would you like to purchase another car? (y/n)");
    string answer = Console.ReadLine();
	if (answer.ToLower() == "n")
	{
		Console.WriteLine("Thank you for shopping with us today!");
		isDoneShopping = true;
	}
	else
	{
		goto tryAgain;
	}


} while (isDoneShopping == false);
