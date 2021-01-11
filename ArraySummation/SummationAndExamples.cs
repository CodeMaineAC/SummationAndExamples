using System;

namespace ArraySummation
{
    class SummationAndExamples
    {
        static void Main(string[] args)
        {
            int[] values = { 7, 10, 12, 5, 8, 19, 22 };
            
            int sum = Summation(values);

            Console.Write("\nArray in Main: ");
            foreach (int i in values) Console.Write(" {0}, ", i);

            PrintArray(values);

            Console.Write("\nArray in Main: ");
            foreach (int i in values) Console.Write(" {0}, ", i);

            Console.WriteLine("\nThe sum is {0}", sum);

            int x = 10;
            Console.WriteLine("\nX in Main: {0}", x);
            ChangeX(x);
            Console.WriteLine("X in Main: {0}", x);
            ChangeRefX(ref x);
            Console.WriteLine("X in Main: {0}", x);
            if(!AbsoluteValueX(x, out int aX))
            {
                Console.WriteLine("X is negative");
            }
            Console.WriteLine("X in Main: {0}, " +
                "AbsoluteValueX output: {1}", x, aX);

            AbsoluteValueX(x, out x);
            Console.WriteLine("X in Main after calling AbsoluteValueX" +
                " with x as an output param: {0}", x);




        }

        private static int Summation(int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; ++i)
            {
                sum += nums[i];
            }
            return sum;
        }

        private static void PrintArray(int[] nums)
        {
            nums[0] = -999; //Just to see how method scope works with arrays
            Console.Write("\nArray in Method: ");
            foreach (int i in nums) Console.Write(" {0}, ", i);
        }

        private static void ChangeX(int x)
        {
            x = -99;
            Console.WriteLine("X in Method: {0}", x);

        }

        private static void ChangeRefX(ref int x)
        {
            x = -99;
            Console.WriteLine("X in Reference Method: {0}", x);

        }

        private static bool AbsoluteValueX(int x, out int absX)
        {
            bool isPostive;
            if(x < 0)
            {
                isPostive = false;
                absX = Math.Abs(x); 
            }
            else 
            {
                isPostive = true;
                absX = x;
            }
            return isPostive;
        }

      

    }
}
