using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
           // LINQ -- Language Integrated Query 
           int[] numbers = {12,14,13,18,58,65,124,95,34,65,};

           var result = numbers.where(num => num > 50).Select(num => num);

        }
    }
}
