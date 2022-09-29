using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{    //Move zeros to beginning or end of array. e.g. if given array is { 2 , 10 , 0 ,5 ,3, 0, 4 ,1}
     //then output array should be a. { 0,0,2,10,5,3,4,1} b. {2,10,5,3,4,1,0,0}
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int[] arr= new int[] { 2,10,0,5,3,0,4,1};

            Console.WriteLine("Output for first option\n");
           for(int i=0;i<arr.Length;i++)
            {
                    if (arr[i] == 0)
                    {
                        Console.WriteLine(arr[i]);
                    }
            }
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != 0)
                {

                    Console.WriteLine(arr[j]);
                   
                }
            } 

            Console.WriteLine("\nOutput of second option\n");

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != 0)
                {

                    Console.WriteLine(arr[j]);

                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
