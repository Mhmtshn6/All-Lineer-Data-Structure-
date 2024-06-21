using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Array
    {
        static void Main(string[] args)
        {
            string[] Software = new string[4];
            // Create Array 

            Software[0] = "C#";
            Software[1] = "C++";
            Software[2] = "Java";
            Software[3] = "Phyton";
            // Add item on Array

            for (int i = 0; i < Software.Length; i++)
            {
                Console.WriteLine(Software[i]);
            }//Print Array

            Console.ReadLine();
        }
    }
}
