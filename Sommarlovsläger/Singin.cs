using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{

    internal class Singin : Program
    {
        List<Switsh1> Switsh1s = new List<Switsh1>();

        public Singin()
        {

        }

        public string Name { get; set; }
        public int Password { get; set; }



        public void AddUser(Switsh1 switsh1)
        {
            Switsh1s.Add(switsh1);

        }

        public void AddUser(String Name, int Password)
        {
            // Console.WriteLine("Skriv Gärna ditt Name: \n");
            // this.Name = Console.ReadLine() + "\n";


            // Console.WriteLine("Skriv gärna att skriva ditt ålder igen: \n");

            // this.Password = int.Parse(Console.ReadLine() + "\n");   



            Console.WriteLine("Va bra  du är välkommen ");



        }

        internal void AddUser(Singin singin)
        {

        }
    }
}
