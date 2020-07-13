// https://programmers.co.kr/learn/courses/30/lessons/12952

using System;
using System.Collections.Generic;

namespace cs_baekjoon
{
    class Problem
    {
        int num = 0;
        int answer = 0;
        List<int> place = new List<int>();

        public int solution(int n)
        {
            int[,] board = new int[n, n];
            num = n;
            board.Initialize();

            NextLine(0);
            return answer;
        }

        void NextLine(int step)
        {
            if (step < num)
            {
                for (int x = 0; x < num; x++)
                {
                    if (CheckQueen(step, x))
                    {
                        if (step == num - 1)
                        {
                            answer++;
                            return;
                        }
                        place.Add(x);
                        NextLine(step + 1);
                        place.RemoveAt(place.Count - 1);
                    }                    
                }
            }
            return;
        }

        bool CheckQueen(int y, int x)
        {
            if (place.Count != 0)
            {
                for (int i = 0; i < place.Count; i++)
                {
                    if (place[i] == x || i - y == place[i] - x|| i - y == x - place[i])
                        return false;
                }
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Problem p = new Problem();
            p.solution(8);
        }
    }
}