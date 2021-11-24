using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Kunder : Program
    {

        List<Switsh1> Switsh1s = new List<Switsh1>();

        private string Name;
        private int Age;


        public Kunder(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;

        }

        public Kunder(string inputName1)
        {
        }

        public string Kund_Name
        {
            get;
            set;
        }



        public string getinfo()
        {
            return "Ditt Namne " + Name + "Din ålder: " + Age;
        }



        public string GetUserName()
        {
            return Name;
        }
        public int GetPasswrod()
        {
            return Age;
        }


        public string Getusernam(Switsh1 switsh1) 
        { 
            return Name;
        }

        public int GetAge(Switsh1 switsh1) { return Age; }



       


    }
}
