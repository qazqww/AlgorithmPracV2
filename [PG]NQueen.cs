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

/*
class Problem
{
    public int solution(int N, int[,] road, int K)
    {
        int answer = 0;
        int[] dist = new int[N];
        int[,] weight = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                dist[j] = 100000;
                if (i == j)
                    weight[i, j] = 0;
                else
                    weight[i, j] = 100000;
            }
        }
        dist[0] = 0;

        for (int i = 0; i < road.GetLength(0); i++)
        {
            if (weight[road[i, 0] - 1, road[i, 1] - 1] > road[i, 2])
            {
                weight[road[i, 0] - 1, road[i, 1] - 1] = road[i, 2];
                weight[road[i, 1] - 1, road[i, 0] - 1] = road[i, 2];
            }
        }

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(0);

        while (queue.Count > 0)
        {
            int num = queue.Dequeue();
            for (int i = 0; i < N; i++)
            {
                if (weight[num, i] < 99999 || weight[num, i] > 0)
                {
                    if (dist[i] > dist[num] + weight[num, i])
                    {
                        dist[i] = dist[num] + weight[num, i];
                        queue.Enqueue(i);
                    }
                }
            }
        }

        for (int i = 0; i < N; i++)
        {
            if (dist[i] <= K)
                answer++;
        }
        return answer;
    }
}
*/