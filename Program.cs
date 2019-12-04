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
            
            int [] array_one = { 1, 5, 2 };

            int[] array_two = { 3,6,4 };

            int[] zipped_array = new int [6];

            for (int i = 0; i < array_one.Length; i++)
            {
                zipped_array[i] = array_one[i];

                

            }

            for (int j = 0; j < array_two.Length; j++)
            {
                zipped_array[j] = array_two[j];


            }

            for (int i = 0; i < zipped_array.Length; i++)
            {
                Console.WriteLine(zipped_array[i]);
            }

            Console.ReadLine();

            

            
        }

        
    }
}
