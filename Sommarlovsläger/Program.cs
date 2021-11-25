using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        public static void Main(string[] args)
        {
            Switsh1 switsh1 = new Switsh1();   
            

            


            int x = 0;
            //Geting users Choise 

            while (true)
            {
                Console.WriteLine("Hej och välkommen till vår Sommarlovsläger\n");
                Console.WriteLine("--------------------------------------------\n");
                Console.WriteLine("1. Menu\n");    
                Console.WriteLine("2. Våra Sommarlovsläger och räkna ut dit ålder  i dagar \n");   
                Console.WriteLine("3. Om Oss\n");
                Console.WriteLine("4. Avsluta \n");

                Console.WriteLine("Skriva in ditt val \n");


                // user try and catch  if users type errors or a letter

                try
                {
                    x = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("indaran var ogiltig. Skriva en siffra");

                }

                //funktion för att få valet

                if (x == 1)
                {

                    while (true)
                    {

                        // menu för programmet 
                        // jag har lagt en annan sätt att man välja istället man skriva siffra 
                        // Nästan allt här


                        string[] menuOptions = new string[] { "Logga in: ", "Registrerar dig:  ", "anmäla om personal: ", "Kundservice: ", "Avsluta"};
                        switsh1.Populate();


                            int menuSelected = 0;
                        while (true)
                        {

                            Console.Clear();

                            Console.CursorVisible = false;

                            if (menuSelected == 0)
                            {
                                Console.WriteLine(menuOptions[0] + "  <---");


                                Console.WriteLine(menuOptions[1]);

                                Console.WriteLine(menuOptions[2]);

                                Console.WriteLine(menuOptions[3]);

                                Console.WriteLine(menuOptions[4]);

                            }


                            else if (menuSelected == 1)
                            {
                                Console.WriteLine(menuOptions[0]);

                                Console.WriteLine(menuOptions[1] + "  <---");

                                Console.WriteLine(menuOptions[2]);

                                Console.WriteLine(menuOptions[3]);

                                Console.WriteLine(menuOptions[4]);

                            }

                            else if (menuSelected == 2)
                            {
                                Console.WriteLine(menuOptions[0]);

                                Console.WriteLine(menuOptions[1]);

                                Console.WriteLine(menuOptions[2] + "  <---");

                                Console.WriteLine(menuOptions[3]);

                                Console.WriteLine(menuOptions[4]);

                            }

                            else if (menuSelected == 3)
                            {
                                Console.WriteLine(menuOptions[0]);

                                Console.WriteLine(menuOptions[1]);

                                Console.WriteLine(menuOptions[2]);

                                Console.WriteLine(menuOptions[3] + "  <---");

                                Console.WriteLine(menuOptions[4]);


                            }

                            else if (menuSelected == 4)
                            {
                                Console.WriteLine(menuOptions[0]);

                                Console.WriteLine(menuOptions[1]);

                                Console.WriteLine(menuOptions[2]);

                                Console.WriteLine(menuOptions[3]);


                                Console.WriteLine(menuOptions[4] + "  <---");

                            }




                            var keyPressed = Console.ReadKey();





                            if (keyPressed.Key == ConsoleKey.DownArrow && menuSelected != menuOptions.Length - 1)
                            {
                                menuSelected++;
                            }

                            else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelected >= 1)
                            {

                                menuSelected--;

                            }


                            else if (keyPressed.Key == ConsoleKey.Enter)
                            {


                                switch (menuSelected)
                                {

                                    case 0:
                                        // Jag kopplade det till en annan class som jag kopplade tillsammans isället jag skriva med samma class

                                        // förta valdet handlar om Inloging som kunden kan komma in om kunden har ett användera name och password



                                        // ner ser du två konto som du kan använda 
                                        // Niklas 30
                                        // Aziz 21
                                        switsh1.FirstChoise();

                                        break;

                                    case 1:
                                        // andra val som handlar om singin in eller skffa ett nytt konto och det är för nya kunder  
                                        switsh1.SecondChoise();

                                        break;

                                    case 2:
                                        // den här valdet handlar om anmäl och krav för att man kan anmäla måste man logga in 

                                        switsh1.ThirdChoise();

                                        break;

                                    case 3:

                                        // Det här vald handlar om Kundservice eller om kunden vill fråga om progmlem eller kan inte logga in (fake)
                                        switsh1.FourthChoise();
                                        break;


                                    case 4:
                                        // det jär valdet handlar om avslutnig eller för att avsluta programmet
                                        switsh1.FifthChoise();
                                        break;


                                    default:
                                        Console.WriteLine("Tror att du ska försöka igen\n");
                                        Console.WriteLine("Obs något gick fel\n");

                                        break;

                                }





                            }




                        }
                        

                        

                    }
                    
                }

                else if (x == 2)
                {
                    // Det här skulle händlar om Sommarlovsläger men eftersom det fake jag gjorde som minräknare kan räkna ut ålder på dagar och på månader 

                    menu menu = new menu();
                    menu.count_age();

                    Console.WriteLine("----------");

                    Console.WriteLine("Tryck Etnter för att gå tillbaka till meny\n");
                    Console.ReadKey();

                }

                else if (x == 3)
                {
                    menu menu = new menu();
                    menu.oss();
                    
                    Console.WriteLine("----------");

                    Console.WriteLine("Tryck Etnter för att gå tillbaka till meny\n");

                    Console.ReadKey();
                }


                else if (x >= 4)
                {
                    Console.WriteLine("Du vill Avsluta ,\n Tryck Etnter för att Avsluta \n");
                    Console.ReadKey();
                    Console.Clear();
                    Environment.Exit(1);


                }

                else
                {
                    Console.WriteLine("Du gjorde inget val,\n Tryck Etnter för att gå tillbaka till meny\n");
                    Console.Clear();    
                    Console.ReadKey();
                    break;

                }



            }











        }
    }
}
