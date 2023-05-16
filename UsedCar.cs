using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLab
{
    internal class UsedCar : Car
    {

        public double Mileage { get; set; }

        public UsedCar(string carMake, string carModel, int carYear, double carPrice, double mileage) : base(carMake, carModel, carYear, carPrice)
        {
            Mileage = mileage;
        }

       public override string ToString()
        {
            return string.Format("{0} {1}, {2}, miles: {4}, ${3}", CarMake, CarModel, CarYear, CarPrice, Mileage);
        }

    }
}
    