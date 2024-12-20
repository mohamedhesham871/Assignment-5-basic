namespace Assignment_5_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q19:Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            Console.WriteLine("enter size of Array");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n)   || n <= 0)
            {
                Console.Write("enter size of Array  integer & positive");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) Console.Write("1 ");
                    else Console.Write("0 ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
