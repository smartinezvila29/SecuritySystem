using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecuritySystem.Models;

namespace SecuritySystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainSystem system = new MainSystem();

            Console.WriteLine("1) \n");
            system.addVisit("Molina", "Rocio", 22222222, "UNLa");
            system.addEmployee("Lopez", "Martin", 33333333, 3829);
            system.addVisit("Martino", "Marcelo", 44444444, "COOP Tic");
            system.addEmployee("Rodriguez", "Lucia", 11111111, 3840);
            foreach (var person in system.GetListPerson())
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine("\n 2) \n");
            Console.WriteLine(system.GetPerson(1).ToString());

            Console.ReadKey();

        }
    }
}
