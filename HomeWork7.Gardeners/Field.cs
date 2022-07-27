using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7.Gardeners
{
    public class Field
    {
       public int[,] GetData()
       {
            Console.WriteLine("Please enter Field length");
            var isLength = int.TryParse(Console.ReadLine(), out var length);

            Console.WriteLine("Please enter Field width");
            var isWidth = int.TryParse(Console.ReadLine(), out var width);

            int[,] array = new int[length, width];

            return array;
       }
    }
}
