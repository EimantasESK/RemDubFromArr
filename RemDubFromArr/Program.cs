using System;

namespace RemDubFromArr
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] RemoveDublicates(int[] nums)
            {
                int[] expectedNum = new int[nums.Length];
                int temp = -1;
                int k = 0;
                
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != temp)
                    {
                        k++;
                        expectedNum[i] = nums[i];
                    }

                    temp = nums[i];
                }

                Console.WriteLine("k = {0}", k);

                if (nums[0] == 0)
                {
                    Console.Write("0, ");
                }


                return expectedNum;
            }
            
            int[] test1 = new int[] { 1, 1, 2 }; //Output: 2, nums = 1,2,
            int[] test2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };  //Output: 5, nums = 0,1,2,3,4,
            
            foreach (var item in RemoveDublicates(test1))
            {
                if ( item != 0)
                {
                    Console.Write("{0}, ", item);
                }
            }
        }
    }
}
