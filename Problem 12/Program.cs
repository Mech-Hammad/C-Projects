using System;
 
namespace P10
{
    class Program {         
        static void Main(string[] args)
        {
            Console.WriteLine("This program swaps 1st and last element of an array");
            Console.WriteLine("We simply store the 1st element in a temporary variable.");
            Console.WriteLine("The replace the 1st element with last element.");
            Console.WriteLine("Then replace the last element with 1st temporary stored value");
            

            
            int[] array = {12,-67, -23, 54,21,-23,8,-23,-9,-2,-3,23,2};
            Console.WriteLine("Original Array: {0}",String.Join(", ",array));

            int temp = array[0];
            array[0] = array[array.Length-1];
            array[array.Length-1] = temp;
            
            Console.WriteLine("Sorted as Required Array: {0}",String.Join(", ",array));


           
            Console.ReadLine();
        }
    }
}
