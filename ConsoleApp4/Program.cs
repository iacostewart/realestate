using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  public  class Program
    {

        static void Main(string[] args)
        {
            
            Customer Contact = new Customer();
            Contact.Greating();
                if(Contact.LookingForHome == "yes")
            {
                Contact.Info();
                Contact.Active = true;

            }
            else
            {
                Contact.Active = false;
                Contact.NotIntrested();
            }


            if (Contact.Active == true)
            {
                Console.WriteLine("Out of the homes we can show you, are you looking to Purchase New Construction or a use home ? ");
                var _homeStatus = Console.ReadLine();

                if(_homeStatus == "new")
                {
                    Contact.NewHome();
                }
            }
               
            
        }
    }
}
