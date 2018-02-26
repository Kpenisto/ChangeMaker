using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program represents a change maker. Please enter any integer between 1 and 99.");
            int change = Convert.ToInt32(Console.ReadLine());

            int quarter = 25;
            int dime = 10;
            int nickle = 5;
            int pennie = 1;
            

            int newquarter = (change / quarter);
            int newdime = ((change % quarter) / dime);
            int newnickle = (((change % quarter) % dime) / nickle);
            int newpennie = ((((change % quarter) % dime) % nickle) / pennie);

            Console.WriteLine("\nWith the change amount of " + change + " the change recieved will be: ");
            Console.WriteLine(newquarter + " quarters");
            Console.WriteLine(newdime + " dimes");
            Console.WriteLine(newnickle + " nickles");
            Console.WriteLine(newpennie + " pennies");


            Console.ReadLine();
        }
    }
}
