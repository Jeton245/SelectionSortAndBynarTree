using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 51;
            int[] array = new int[] { 51, 23, 1, 71, 81, 9, 56, 28 };
            
            findSmallest(array);
          
            Console.WriteLine(BinarThree(array, index)); 
            
        }
        static int[] findSmallest(int[] array)
        {
            int minIndex = 0;
            for(int i = 0; i < array.Length-1; i++)
            {
                minIndex = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                        
                    }
                    
                }

                if (i != minIndex)
                {
                    int num = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = num;
                }
            }
            return array;
        }

        static int BinarThree(int[]massiv,int index)
        {
            int low = 0;
            int higth = massiv.Length - 1;
            while(low < higth)
            {
                int mid = low + higth;
                int guess = massiv[mid];
                if(guess == index)
                {
                    return mid;
                }
                if(mid > guess)
                {
                    return mid - 1;
                }
                else
                {
                    return mid + 1;
                }
            }
            return 0;
        }
       
    }
}

