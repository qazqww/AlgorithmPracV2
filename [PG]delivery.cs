// https://programmers.co.kr/learn/courses/30/lessons/12978

using System;
using System.Collections.Generic;

namespace cs_baekjoon
{
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
                    dist[j] = 1000000;
                    if (i == j)
                        weight[i, j] = 0;
                    else
                        weight[i, j] = 1000000;
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
                    if (weight[num, i] < 999999 || weight[num, i] > 0)
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

    class Program
    {
        static void Main(string[] args)
        {
            Problem p = new Problem();
        }
    }
}