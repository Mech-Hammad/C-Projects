using System;
 
namespace P10
{
    class Program {         
        static void Main(string[] args)
        {
            Console.WriteLine("The relative position of positive numbers remains unchanged.");
            Console.WriteLine("The relative position of negative numbers remains unchanged.");
            Console.WriteLine("The positive numbers are concentrated to the left while negative numbers are concentrated to the right");

            
            int[] array = {12,-67, -23, 54,21,-23,8,-23,-9,-2,-3,23,2};
            Console.WriteLine("Original Array: {0}",String.Join(", ",array));

            for(int i=0;i<array.Length; i++)
            {
                if (array[i]>=0) //Negative Number
                {
                    int j = i-1;
                    while(j>=0 && array[j]<0)// Next number is also negative
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                        j--;
                    }
                }
            }
            Console.WriteLine("Arranged Array: {0}",String.Join(", ",array));

            Console.ReadLine();
        }
    }
}
