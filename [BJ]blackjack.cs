// https://www.acmicpc.net/problem/2798

using System;

namespace cs_baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ');
            string[] str2 = Console.ReadLine().Split(' ');

            int maxNum = -1;
            int cards = int.Parse(str1[0]);
            int target = int.Parse(str1[1]);
            int[] nums = new int[cards];

            for (int i = 0; i < str2.Length; i++)
                nums[i] = int.Parse(str2[i]);
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] + nums[i] + nums[i] > target)
                    break;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] + nums[j] > target)
                        break;

                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int result = nums[i] + nums[j] + nums[k];
                        if (result > target)
                            break;
                        if (result > maxNum)
                            maxNum = result;
                    }
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
