using System;
using System.Text;

namespace Car_Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carMark = {"Audi TT", "Audi RS", "BMW X7", "BMW X5", "Mercedec McLaren", "Opel ASTRA", "Chevrolet Camaro", "Chevrolet Impala", "Ford GT", "Ford Mustang", "Bugatti Veyron"};

            string[] nameOfPeople = { "Andriy", "Misha", "Ivan", "Vlad", "Oleksandr", "Robert", "Mike", "Cris", "Evan", "Joel"};

            Random random = new Random();
            int customerCount = random.Next(1, 10);

            var usersWithCars = new string[customerCount];

            for (int i = 0; i < usersWithCars.Length; i++)
            {
                usersWithCars[i] = nameOfPeople[i] + " - " + carMark[i];
            }
            
            int j = 0;
            foreach (var item in usersWithCars)
            {
                Console.WriteLine(usersWithCars[j]);
                j++;
            }

            Console.WriteLine($"User without cars: {nameOfPeople.Length - customerCount}");
        }
    }
}