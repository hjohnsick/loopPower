using System;
using System.Diagnostics.CodeAnalysis;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum;
            int powNum;
            string response;



            do
            {
                Console.WriteLine("Would you like to enter a number?\nYes or No");
                response = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter number one: ");
                baseNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter number two: ");
                powNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine(GetPower(baseNum, powNum));
                Console.WriteLine("Do you want to continue?\nYes or No");
                response = Console.ReadLine();
            }
            while (response == "yes");

            Console.WriteLine("Thank you for playing!");
           
        }

        public static double GetPower(int baseNum, int powNum)
        {
            double result = 1;
            if(powNum > 0)
            {
                for(int i = powNum; i > 0; i--)
                {
                    result = result * baseNum;
                }
            }
            else if (powNum < 0)
            {
                for(int i = powNum; i < 0; i++)
                {
                    result = result / baseNum;
                }
            }

            return result;
        }
      

    }
}
