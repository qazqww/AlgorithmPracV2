// https://www.acmicpc.net/problem/2447

using System;
using System.Collections.Generic;
using System.Text;

namespace cs_baekjoon
{
    class Function
    {
        public void Star(int num)
        {
            List<StringBuilder> stars = new List<StringBuilder>();
            List<StringBuilder> fakes = new List<StringBuilder>();

            stars.Add(new StringBuilder("***"));
            stars.Add(new StringBuilder("* *"));
            stars.Add(new StringBuilder("***"));

            while (num > 3)
            {
                fakes.Clear();
                for (int i = 0; i < stars.Count; i++)
                    fakes.Add(new StringBuilder(stars[i].ToString()));

                // 옆으로 늘리는 과정
                for (int i = 0; i < stars.Count; i++)
                {
                    string strTemp = stars[i].ToString();
                    string fake = strTemp.Replace('*', ' ');
                    stars[i].Append(strTemp);
                    stars[i].Append(strTemp);
                    fakes[i].Append(fake);
                    fakes[i].Append(strTemp);
                }

                // 밑으로 늘리는 과정
                int temp = stars.Count;
                for (int i = 0; i < temp; i++)
                    stars.Add(new StringBuilder(fakes[i].ToString()));
                for (int i = 0; i < temp; i++)
                    stars.Add(new StringBuilder(stars[i].ToString()));

                num /= 3;
            }

            for (int i = 0; i < stars.Count; i++)
                Console.WriteLine(stars[i]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Function f = new Function();

            int num = int.Parse(Console.ReadLine());
            f.Star(num);
        }
    }
}
