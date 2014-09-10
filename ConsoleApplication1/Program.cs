using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MySortedList<int> list = new MySortedList<int>();

            while (true)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                list.Add(number);
                Console.WriteLine(list.ToString());
            }
        }





    }
}
