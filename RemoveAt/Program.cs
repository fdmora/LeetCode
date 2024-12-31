using System;

namespace ConsoleApp6
{
    public class Program
    {

        static void Main(string[] args)
        {
            /// <summary>
            /// RemoveElement call
            /// </summary>
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            RemoveElement(nums1, m);

            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine(nums1[i]);
            }

            Console.ReadLine();


        }      

        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}