using System;
using System.Collections.Generic;

namespace Practice_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> angka = new List<int> { 1,2,3,4,5,9,8,7,6};

            Func<int, int, int> kuadra = (x,y) => x + y*y;

            Console.WriteLine(kuadra(11,12));

            Console.ReadLine();

        }
    }
}
