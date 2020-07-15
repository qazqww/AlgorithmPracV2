// https://www.acmicpc.net/problem/1018

using System;

namespace cs_baekjoon
{
    class Problem
    {
        string[] lines;
        int answer = int.MaxValue;

        public void solution()
        {
            string[] s = Console.ReadLine().Split(' ');
            int y = int.Parse(s[0]);
            int x = int.Parse(s[1]);
            lines = new string[y];
            
            for (int i = 0; i < y; i++)
                lines[i] = Console.ReadLine();

            for (int i = 0; i <= y - 8; i++)
            {
                for (int j = 0; j <= x - 8; j++)
                {
                    int count = Count(i, j);
                    if (answer > count)
                        answer = count;
                }
            }

            Console.WriteLine(answer);
        }

        int Count(int curY, int curX)
        {
            int bw = BWCount(curY, curX);
            int wb = WBCount(curY, curX);
            return (bw < wb) ? bw : wb;
        }

        int BWCount(int curY, int curX)
        {
            int count = 0;

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0) // 0 2 4 6 라인
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            if (lines[curY + i][curX + j] == 'W')
                            {
                                count++;
                                if (count >= answer)
                                    return answer + 1;
                            }
                        }
                        else
                        {
                            if (lines[curY + i][curX + j] == 'B')
                            {
                                count++;
                                if (count >= answer)
                                    return answer + 1;
                            }
                        }
                    }
                }
                else // 1 3 5 7 라인
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            if (lines[curY + i][curX + j] == 'B')
                            {
                                count++;
                                if (count >= answer)
                                    return answer + 1;
                            }
                        }
                        else
                        {
                            if (lines[curY + i][curX + j] == 'W')
                            {
                                count++;
                                if (count >= answer)
                                    return answer + 1;
                            }
                        }
                    }
                }
            }

            return count;
        }

        int WBCount(int curY, int curX)
        {
            int count = 0;

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0) // 0 2 4 6 라인
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            if (lines[curY + i][curX + j] == 'B')
                            {
                                count++;
                                if (count >= answer)
                                    return answer + 1;
                            }
                        }
                        else
                        {
                            if (lines[curY + i][curX + j] == 'W')
                            {
                                count++;
                                if (count >= answer)
                                    return answer + 1;
                            }
                        }
                    }
                }
                else // 1 3 5 7 라인
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            if (lines[curY + i][curX + j] == 'W')
                            {
                                count++;
                                if (count >= answer)
                                    return answer + 1;
                            }
                        }
                        else
                        {
                            if (lines[curY + i][curX + j] == 'B')
                            {
                                count++;
                                if (count >= answer)
                                    return answer + 1;
                            }
                        }
                    }
                }
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Problem p = new Problem();
            p.solution();
        }
    }
}