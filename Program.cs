namespace Assignment_5_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q19:Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.WriteLine("enter size of Array");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("enter size of Array  integer & positive");
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j) Console.Write("1 ");
            //        else Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q20:Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] Arr = [10,20,30,32,41,41,352,1,345,346];

            //int sum = 0,sum1=0;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    sum += Arr[i];
            //}
            //Console.WriteLine($"the sum of Array is : {sum}");

            //// Another solve 
            //Console.WriteLine("enter size of Array");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("enter size of array  integer & positive");
            //}
            //int[] arr = new int[n];

            //for(int i = 0;i < n;i++)
            //{
            //    int x;
            //    while (!int.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.Write("enter size of array  integer");
            //    }
            //    arr[i] = x;
            //    sum1 += x;

            //}
            //Console.WriteLine($"the sum of Array is : {sum1}");
            #endregion
            #region Q21:Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order
            // i will make merge sort in this example :)
            int[] arr1 = { 1, 2, 7,15 };
            int[] arr2 = { 4, 6, 9, 14 };
            int [] mergedArray= new int[arr1.Length*2-1];
            int i = 0,j=0,z=0;

            //while (i<arr1.Length && j<arr2.Length)
            //{
            //    if (arr1[i] <= arr2[j] )
            //    {
            //        mergedArray[z] = arr1[i];
            //        i++;
            //    }
            //    else
            //    {
            //        mergedArray[z] = arr2[j];
            //        j++;
            //    }
            //    z++;
            //}
            //Console.WriteLine(string.Join(',',mergedArray));

            //Another solve 
            //for (int x=0; x<arr1.Length; x++)
            //{
            //    mergedArray[z] = arr1[x];
            //    z++;
            //}
            //z--;
            //for (int x = 0; x < arr2.Length; x++)
            //{
            //    mergedArray[z] = arr2[x];
            //    z++;
            //}
            //Array.Sort(mergedArray);
            //Console.WriteLine(string.Join(',', mergedArray));

            #endregion
        }
    }
}
