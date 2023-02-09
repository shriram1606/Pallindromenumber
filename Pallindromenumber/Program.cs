using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Pallindromenumber
{
    internal class Program
    {
        //write a c# program to pallindrome number
        static void Main(string[] args)
        {
            int number, total = 0, t, reverse;
            Console.WriteLine("enter the number");
            number = int.Parse(Console.ReadLine());
            t = number;

            while(number>0)
            {
                reverse = number % 10;
                total = (total * 10) + reverse;
                number = number / 10;
            }

            if(t==total)
            {
                Console.WriteLine("the  given number is pallindrome");
            }
            else
            {
                Console.WriteLine("the given number is not pallindrome");
            }
        }
    }
}
