using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLab
{

    internal class Car
    {
        

        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public double CarPrice { get; set; }

        public static List<Car> CarsList { get; set; }


        public Car()
        {
            CarMake = "";
            CarModel = "";
            CarYear = 0;
            CarPrice = 0;

            CarsList = new List<Car>(); 

        }
        public Car(string carMake, string carModel, int carYear, double carPrice)
        {
            CarMake = carMake;
            CarModel = carModel;
            CarYear = carYear;
            CarPrice = carPrice;

            CarsList = new List<Car>();

        }
        public virtual string ToString()
        {
            return string.Format("{0} {1}, {2}, ${3}", CarMake, CarModel, CarYear, CarPrice);
        }

          
        public static void ListCars(List<Car> carsList)
        {
            for(int i = 0; i < carsList.Count; i++)
            {
                Console.WriteLine($"{i}, {carsList[i].ToString()}");
            }
        }

        public static void Remove(int indexToRemove, List<Car> carsList)
        {
           carsList.RemoveAt(indexToRemove);
        }

       
    }
}
