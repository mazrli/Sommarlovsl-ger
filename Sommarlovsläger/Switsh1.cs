using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Switsh1 : Program
    {
        antalkunder antalkunder = new antalkunder();

        static Report report = new Report();

        public void Populate()
        {
            // det hät dörsta sätt för att kunden kan logga in 
            // name = Niklas och password = 30
            // name = aziz och password = 21

            antalkunder.addkunder("Niklas", 30);
            antalkunder.addkunder("Aziz", 21);
        }


        public void FirstChoise()
        {



             

            
            



            bool loggedin = false;


            do
            {



                Console.WriteLine("Skriva ditt använder Name");
                string inputName = Console.ReadLine();

                Console.WriteLine("Skriva Password");
                int inputPassword = Convert.ToInt32(Console.ReadLine());



                int kundid = antalkunder.ConfirmUser(inputName, inputPassword);
                if (kundid > -1)
                {
                    loggedin = true;
                }
                else if (kundid == -1)
                {
                    Console.WriteLine("Incorrect password");
                }
                else if (kundid == -2) 
                {
                    Console.WriteLine("No such user.");
                }
                
                
                


            }

            while (loggedin == false);





            do
            {
                Console.WriteLine("Insert, Retrive or Avsluta? ");
                string inputs = Console.ReadLine();

                if (inputs == "Insert" || inputs == "insert")
                {
                    Console.WriteLine("-----------");
                    break;
                }

                else if (inputs == "retrive" || inputs == "Retrive")
                {
                    Console.WriteLine("´------");
                    break ;
                }

                else if (inputs == "Avsluta" || inputs == "avsluta")
                {
                    Console.Clear();
                    Console.ReadKey();
                    Environment.Exit(1);


                }







            } while (loggedin == true);







            Console.Read();

        }
        public void SecondChoise()
        {


            Console.WriteLine("Hej och välkommen till oss\n");
            Console.WriteLine("Vad roligt att du vill vara en av oss\n ");
            Console.WriteLine("Innan du kan reigsterar dig här vill vi att frågra några frågor\n");
            Console.WriteLine("Hur gammal är du? ?\n");
            Console.WriteLine("Skriv din ålder");




            int q = 0;




                try
                {
                    q = int.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("indaran var ogiltig. Skriva en siffra");
                    
                }



                if (q >= 18)
                {


                Console.WriteLine("Du är välkommen att skffa ett konto hos oss. \n");
                Console.WriteLine("för att kunna skffa ett nytt konto");


  




                   

                Console.WriteLine("Skriva ditt använder Name");
                
                string inputName1 = Console.ReadLine();

                
                Console.WriteLine("Skriva Password");
                
                int inputPassword1 = Convert.ToInt32(Console.ReadLine());

                antalkunder.addkunder(inputName1, inputPassword1);

                  
                
                Console.WriteLine( "Så ditt User är  " + inputName1 +"  och ditt Password " + inputPassword1 + " .");
                
                Console.WriteLine("Tryck Enter för att gå tillbaka till Menu.");

                
                Console.ReadLine();




                    

                    

                }
                else if (q <= 17)
                {
                
                Console.Clear();
                
                Console.WriteLine("Du kan tyvärr inte reigsterar dig hos oss, \n");
                
                Console.WriteLine("Du är minder än 18 och det är därför kan du inte skffa ett konto hos oss. \n");
                
                Console.ReadKey();


                }

                else
                {
                
                Console.WriteLine("Du gjorde inget val,\n Tryck Etnter för att gå tillbaka till meny\n");
                
                Console.Clear();
                
                Console.ReadKey();
                
            
                }
            







        }

        public void ThirdChoise()
        {

            
            Console.WriteLine("Du vald att anmäla personal ");


            
            Console.WriteLine("-------------");

            Console.WriteLine("För att kunna göra anmäla vill vi att logga in: ");



            


            //antalkunder antalkunder = new antalkunder();
            // det hät första sätt för att kunden kan logga in 
            // name = Niklas och password = 30
            // name = aziz och password = 21

            //antalkunder.addkunder("Niklas", 30);
            //antalkunder.addkunder("Aziz", 21);











            bool loggedin = false;


            do
            {



                Console.WriteLine("Skriva ditt använder Name");
                string inputName = Console.ReadLine();

                Console.WriteLine("Skriva Password");
                int inputPassword = Convert.ToInt32(Console.ReadLine());




                int kundid = antalkunder.ConfirmUser(inputName, inputPassword);
                if (kundid > -1)
                {
                    loggedin = true;
                }
                else if (kundid == -1)
                {
                    Console.WriteLine("Incorrect password");
                }
                else if (kundid == -2)
                {
                    Console.WriteLine("No such user.");
                }





            }

            while (loggedin == false);





            do
            {
                Console.WriteLine("Anmäla skada, anmäla fel faktura or Avsluta? \n");

                Console.WriteLine("Om det är Anmäla skada skriv (Skada)\n");
                
                Console.WriteLine("Om det är Anmäla skada skriv (faktura)\n");

                Console.WriteLine("OM du vill Avsluta skriv (Avsluta\n)");

                string inputs = Console.ReadLine();

                if (inputs == "Skada" || inputs == "skada")
                {
                    Report Report = new Report();
                    // kopplade från andra class till den här class 
                    Report.Rapportera();

                    Console.WriteLine("-----------");
                }

                else if (inputs == "Faktura" || inputs == "faktura")
                {

                    Report Report = new Report();
                    Report.Faktura();

                    Console.WriteLine("´------");
                }

                else if (inputs == "Avsluta" || inputs == "avsluta")
                {
                    Console.Clear();
                    Console.ReadKey();
                    Environment.Exit(1);
                }







            } while (loggedin == true);








            Console.Read();




        }
        public  void FourthChoise()
        {



            while (true)
            {

                // tre olika sätt att man välja här kommer jag med lite förslag med 
                Console.WriteLine("Du kommer fram till Kundservice \n");
                Console.WriteLine("Välja vilket ärente vill komma fram\n");
                Console.WriteLine("1. Problem med att logga in: \n");
                Console.WriteLine("2. Kan int registrera dig: \n");
                Console.WriteLine("3. anmäla skada: \n");
                Console.ReadKey();

                int w = 0;


                try
                {
                    w = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("indaran var ogiltig. Skriva en siffra");

                }




                if (w == 1)
                {
                    Console.WriteLine("Du vald (Problem med att logga in) \n ");
                    Console.WriteLine("För att kunna logga in  .  .  .  . ");
                    Console.ReadKey();

                    break;
                }

                else if (w == 2)
                {
                    Console.WriteLine("Du vald (Kan int registrera dig) \n");
                    Console.WriteLine("För att kan man registrera sig,\n behöver man framförst personnummer och man måste vara över 18.");
                    Console.WriteLine("Men du kan lösa det genom att något som är över 18 kan boka för dig och honom samt tiden \n");
                    Console.WriteLine("Tryck Enter för att gå tillbaka till menu  .  .  .  .\n");
                    Console.ReadKey();
                    break;

                }

                else if (w == 3)
                {
                    Console.WriteLine("För att Anmäla skada enkelt genom att ringa till våra Kundservice på T. 03432444 \n");
                    Console.WriteLine("Tryck Enter för att gå tillbaka till menu .  .  .  .\n");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.ReadKey();
                    break;
                }
            }

        }



        public void FifthChoise()
        {
            Console.Clear();

            Console.WriteLine("Du vill avsluta program\n");
            Console.ReadKey();
            Environment.Exit(1);


        } 
    }
}
