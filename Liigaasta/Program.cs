using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liigaasta
{
    class Program
    {
        static void Main(string[] args)
            
        {
            /*int yearofbirth;
        
            Console.WriteLine("Enter youre year of birth");
            yearofbirth = Int32.Parse(Console.ReadLine());

            if (yearofbirth % 4 == 0)
            {
                Console.WriteLine($"{yearofbirth} was a leap year");
            }
            else
            {
                Console.WriteLine($"{yearofbirth} was not a leap year");

            }


        //Ternary Operator
        // teine võimalus 
        /*string answer = (yearofbirth % 4 == 0) ? "Leap Year," : "Not a Leap Year,";
        Console.WriteLine(answer);

            Console.ReadLine();*/


        
           Console.WriteLine("Choose youre poison, Whisky of Wine");
            string userChoice = Console.ReadLine();
        
            string choice = userChoice ==" whisky " ? " Here is your whisky," : "Here is your wine";

            Console.WriteLine(choice);

            Console.ReadLine();


            
            

            

        }


        
    }



}
