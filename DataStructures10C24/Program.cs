namespace DataStructures10C24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            string[] names = new string[10];
            names[0] = "John";
            int numberOfItems;
            Console.Write("How many items do you want to store?: ");
            numberOfItems = Convert.ToInt32(Console.ReadLine());
            bool[] userBoolArray = new bool[numberOfItems];

            for(int i = 0;i<nums.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }


            int[,] twoD = new int[3, 5];
            twoD[1, 2] = 5;

            int[,] twoDNums = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int row =0;row<twoDNums.GetLength(0);row++)
            {
                for(int col=0;col<twoDNums.GetLength(1);col++)
                {
                    Console.Write(twoDNums[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
