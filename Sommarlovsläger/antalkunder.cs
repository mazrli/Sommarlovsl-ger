using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class antalkunder : Program
    {
      

        List<Kunder> kunders = new List<Kunder>();
        


        int currentUser = 0;


        public antalkunder()
        {
            addkunder("Jon", 30);
            addkunder("Aziz", 21);







        }

        public int ConfirmUser(string Name, int password)
        {
            int result = -2;
            for  (int i =0; i < kunders.Count; i++)
            {
                if (Name == kunders[i].GetUserName()) 
                {
                    result = -1;
                    if (password == kunders[i].GetPasswrod())
                    {
                        currentUser = i;
                        return currentUser;
                    }
                }
            }
            return result;



        }





        public  void addkunder(Kunder kunder, string inputName1, int inputPassword1)
        {
            this.kunders.Add(kunder);
         

            


        }




        public void addkunder(string Name, int password)
        {
            kunders.Add(new Kunder(Name, password));

            

        }
 

        








        
    }
}
