using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_07._02._2023
{
    internal class City {
        private string city;
        private string country;
        private int population;
        private int city_code;
        private List<string> areas = new List<string>();    

        public City() { }
        public City(string city, string country, int population, int city_code, List<string> areas) {
            this.city = city;
            this.country = country;
            this.population = population;
            this.city_code = city_code;
            this.areas = areas;
        }

        public void Enter() {
            Console.Write("Enter name of city: ");
            city = Console.ReadLine();
            Console.Write("Enter name of country: ");
            country = Console.ReadLine();
            Console.Write("Enter population of city: ");
            string p = Console.ReadLine();
            population = Convert.ToInt32(p);
            Console.Write("Enter city code: ");
            string c = Console.ReadLine();
            city_code = Convert.ToInt32(c);
            Console.Write("Enter amount of areas: ");
            string a = Console.ReadLine();
            int amount = Convert.ToInt32(a);
            Console.WriteLine("Enter areas of city:");
            for(int i = 0; i < amount; i++) { 
                areas.Add(Console.ReadLine());
            }
        }

        public void Print() {
            Console.Write($"City: {city}\n");
            Console.Write($"Country: {country}\n");
            Console.Write($"Population: {population}\n");
            Console.Write($"City code: {city_code}\n");
            Console.Write($"Areas: {areas}\n");
        }

    }
}
