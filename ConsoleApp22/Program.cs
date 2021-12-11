using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int[] arr1 = { 2, 4, 6, 8, 10 };




            array.resize(ref arr1, arr1.length + arr.length);



            for (int i = arr.length, a = 0; i < arr1.length & a < arr.length; a++, i++)
            {

                arr1[i] = arr[a];


            }
            array.sort(arr1);

            foreach (var item in arr1)
            {
                console.writeline(item);
            }
            int[] arr2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr3 = new int[5];
            int[] arr4 = new int[5];

            for (int i = 0,a=0; i < arr2.Length&a<arr3.Length; i++)
            {
                if (arr2[i] % 2 == 0)
                {
                    arr3[a] = arr2[i];
                    a++;
                }
                else
                {
                    arr4[a] = arr2[i];
                    
                }
            }
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }
            foreach (var item in arr4)
            {
                Console.WriteLine(item);
            }

        }
    }
}
