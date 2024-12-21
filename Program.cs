using System.Security.Cryptography;

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
            //    Console.Write("enter integer & positive");
            //}
            //int[] arr = new int[n];

            //for(int i = 0;i < n;i++)
            //{
            //    int x;
            //    while (!int.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.Write("enter   integer");
            //    }
            //    arr[i] = x;
            //    sum1 += x;

            //}
            //Console.WriteLine($"the sum of Array is : {sum1}");
            #endregion
            #region Q21:Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order
            // i will make merge sort in this example :)
            //int[] arr1 = { 1, 2, 7,15 };
            //int[] arr2 = { 4, 6, 9, 14 };
            //int [] mergedArray= new int[arr1.Length*2-1];
            //int i = 0,j=0,z=0;

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
            #region Q22:Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr = { 10, 10, 3, 4, 2, 3, 2, 4, 4, 10 };
            //// You can enter Array  
            //// But i make it to show You result 
            //Array.Sort(arr);
            //int prev = arr[0];
            //int count = 1;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] == prev)
            //        count++;
            //    else
            //    {
            //        Console.WriteLine($"{prev} and freq is : {count} ");
            //        count = 1;
            //        prev = arr[i];
            //    }
            //}
            //Console.WriteLine($"{prev} and freq is : {count} ");

            #endregion
            #region Q23: Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.WriteLine("enter size of Array");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("enter size of Array  integer & positive");
            //}
            //int[] arr = new int[n];
            //int min=int.MaxValue; 
            //int max=int.MinValue;
            //for (int i = 0; i < n; i++)
            //{
            //    int x;
            //    while (!int.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.Write("enter   integer");
            //    }
            //    arr[i] = x;
            //    if(x < min)
            //    {
            //        min= x;
            //    }
            //    if(x > max)
            //    {
            //        max= x;
            //    }

            //}
            //Console.WriteLine($"min number is {min}\nmax number is {max}");
            #endregion
            #region Q24: Write a program in C# Sharp to find the second largest element in an array.
            //Console.WriteLine("enter size of Array");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("enter size of Array  integer & positive");
            //}
            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    int x;
            //    while (!int.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.Write("enter   integer");
            //    }
            //    arr[i] = x;
            //}
            //Array.Sort(arr);
            //Console.WriteLine($"the second largest element {arr[n - 2]}");
            #endregion
            #region Q25:write a program find the longest distance between Two equal cells
            //Console.WriteLine("enter size of Array");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("enter size of Array  integer & positive");
            //}
            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    int x;
            //    while (!int.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.Write("enter   integer");
            //    }
            //    arr[i] = x;
            //}

            //int dis=0 ;
            //for (int i = 0;i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j] && ((j - 1) - (i) > dis))
            //            dis = (j - 1) - (i);
            //    }
            //}

            //Console.WriteLine($"the longest distance is {dis}");
            #endregion
            #region Q26: Given a list of space separated words, reverse the order of the words.
            //Console.WriteLine("enter string ");
            //string x = Console.ReadLine();
            //string[] arr = x.Split(' ');
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            #endregion
            #region Q27:Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.WriteLine("enter size of Array");
            //int n = int.Parse(Console.ReadLine());
            //int[,] arr = new int[n,n];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //        arr[i,j]=int.Parse(Console.ReadLine());
            //}
            //int[,] arr2 = new int[n,n];

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr2[i, j] = arr[i, j];
            //        Console.Write($"{arr2[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Q28:Write a Program to Print One Dimensional Array in Reverse Order
            //Console.WriteLine("enter size of Array");
            //int x=int.Parse(Console.ReadLine());
            //int[] arr=new int[x];
            //for (int i = 0; i < x; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i=x-1;i>=0;i--)
            //{
            //    Console.WriteLine(arr[i]);  
            //}

            #endregion
            #region Q1 Function:Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //when you use calling BY Value work as you take copy  OR temporary data  as any chane on data does not effect on real data 
            //once you finish function will found no change happen on data   finally function Being in Stack 

            //when You use calling BY Address You you sent Address that contain data  so any change will effect on data out side function 
            //once you finish will find changing on data  and funtion Be in Heap 

            //example  (Swap Two numbers)
            int x = 10;
            int y = 20;
            Console.WriteLine("data Befor Function");
            Console.WriteLine(x + "  " + y);
            Swap1(x, y);
            Console.WriteLine("data After Function");
            Console.WriteLine(x + "  " + y);
            //As we see no difference 

            //use Address
            Console.WriteLine("data using call By address Function");
            Swap2(ref x, ref y);
            Console.WriteLine("data After Function");
            Console.WriteLine(x + "  " + y);


            static void Swap1(int num1, int num2)
            {
                int Temp = num1;
                num1 = num2;
                num2 = Temp;
                Console.WriteLine("data in Function");
                Console.WriteLine(num1 + "  " + num2);
            }
            static void Swap2( ref int num1,  ref int num2)
            {
                int Temp = num1;
                num1 = num2;
                num2 = Temp;
                Console.WriteLine("data in Function");
                Console.WriteLine(num1 + "  " + num2);
            }
            #endregion
        }
       
    }
}
