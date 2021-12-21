using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Test
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string Capital { get; set; }
    }
    
    class Program
    {
        static void Main()
        {
            List<Country> countries = new()
            {
                new() {Name = "Russia", Population = 245, Capital = "Moscow"},
                new() {Name = "China", Population = 1000, Capital = "Pekin"},
                new() {Name = "Japan", Population = 500, Capital = "Tokio"}
            };

            var request1 = from country in countries
                where country.Population < 1000
                select country.Name;

            var request2 = countries
                .Where(c => c.Population < 1000)
                .Select(c => c.Name);
            
            
            Show(request1);
            Show(request2);
        }

        static void Show(IEnumerable<string> val)
        {
            foreach (var item in val)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
    }
}