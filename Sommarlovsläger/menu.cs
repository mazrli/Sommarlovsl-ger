using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class menu : Program
    {

        public static void oss()
        {
            Console.WriteLine("Hej");
        }



        public static void count_age()
        {
            
            Console.WriteLine("Hej var roligt att du är här.\n");
            Console.WriteLine("Vi vill att du ska testa dig och räkna ut din ålder i dagar och veckor \n");
            int currentYear = DateTime.Now.Year;

            int currentMonth = DateTime.Now.Month;

            int currentDay = DateTime.Now.Day;

            Console.WriteLine("Skriva in föödesdag: \n");

            Console.WriteLine("År: \n");

            int birthYear = 0;
            birthYear = int.Parse(Console.ReadLine());


            Console.WriteLine("månader: \n");

            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Dag: \n");

            int birthDay = int.Parse(Console.ReadLine());

            int age;
            if (currentMonth < birthMonth) age = currentYear - birthYear - 1;
            else age = currentYear - birthYear;
            Console.WriteLine("Din ålder : {0}"  , age);
            Console.WriteLine("-----------------------------------------------\n");

            int monthAge = 0;
            if (currentMonth < birthMonth)
            {
                monthAge = 12 * age + (11 - (birthMonth - currentMonth));
            }


            else
            {
                monthAge = 12 * age + (currentMonth - birthMonth);
            }


            Console.WriteLine("Din ålder i månader : {0}", monthAge);


            Console.WriteLine("-----------------------------------------------\n");

            int dayAge = monthAge * 30;

            Console.WriteLine("Din ålder räknar i dager är : {0}", dayAge);

            Console.WriteLine("-----------------------------------------------\n");

            Console.WriteLine("Du har {0} år, {1} månader och {2} dag :\n ", age, monthAge, dayAge);

            Console.WriteLine("-----------------------------------------------\n");

            Console.Write("Tryck Enter för att gå tillbaka till Menu . . . ");

            Console.ReadKey(true);
            
        }
        


        

    }
}
