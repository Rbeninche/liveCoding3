using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liveCoding3
{
    class Program
    {
        static void Main(string[] args)


        {


            int[] array_one = { 1, 5, 2 };
            int[] array_two = { 3, 6, 4 };
            var zipped_array = new List<int>();
            for (int i = 0; i < array_one.Length; i++)
            {
                zipped_array.Add(array_one[i]);
                zipped_array.Add(array_two[i]);
            }

            foreach (var num in zipped_array)
            {
                Console.WriteLine(num);

            }

            Console.ReadLine();

            

            
        }

        
    }
}
