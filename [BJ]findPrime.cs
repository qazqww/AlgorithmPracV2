// https://www.acmicpc.net/problem/1978

using System;

namespace cs_baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] numsStr = Console.ReadLine().Split(' ');
            int[] nums = new int[count];

            for (int i = 0; i < count; i++)
            {
                nums[i] = int.Parse(numsStr[i]);
                if (nums[i] == 1)
                    nums[i] = -1;
            }

            Array.Sort(nums);
            double max = Math.Sqrt(nums[nums.Length - 1]);

            for (int mod = 2; mod <= max; mod++)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] <= mod)
                        continue;
                    if (nums[i] > 0 && nums[i] % mod == 0)
                        nums[i] = -1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                    count--;
            }

            Console.WriteLine(count);
        }
    }
}
