using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Customer : ProperitySearch
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Budget { get; set; }
        public string LookingForHome { get; set; }
        public bool Active { get; set; }
        public bool LookingForNewHome { get; set; }

       

        public void Greating()
        {
            Console.WriteLine("hello and welcome, what is your name? ");
            this.Name = Console.ReadLine();
           
            Console.Write("please enter your phone number: ");
            this.PhoneNumber = Console.ReadLine();
            Console.Write("Are you looking for a home? :");
            this.LookingForHome = Console.ReadLine();
                if(LookingForHome == "yes")
            {
                Console.WriteLine("What is your Home buying Budget? :");
                this.Budget = int.Parse(Console.ReadLine());
            
            }
                
        }

       public  void Info()
        {
            Console.WriteLine($"Customer Name : {this.Name}");
            Console.WriteLine($"Phone Number : {this.PhoneNumber}");
            Console.WriteLine($"Active Budget : {this.Budget}");
        }

        public void NotIntrested()
        {
            Console.Write("well we are house selling people.. good day to you");
        }

        public void NewHome()
        {
            this.LookingForNewHome = true;
            Console.WriteLine("Do you have your own land? or are you intrested in living in a people farm? :");
          Console.WriteLine("1: yes  /   2: no ");
             int _landOption = int.Parse(Console.ReadLine());
             if(_landOption == 1)
            {
                this.OwnesLand  = true;
            }
            else
            {
                this.OwnesLand  = false;
            }
           
        }

        public void UsedHOme()
        {
            this.LookingForNewHome = false;
        }
    }

    


}
