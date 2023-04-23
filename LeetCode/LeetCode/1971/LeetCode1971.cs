using System.Collections.Generic;

public static class LeetCode1971
{
    public static bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        if (n <= 0)
        {
            return false;
        }

        if (edges.Length == 0 && source == 0 && destination == source)
        {
            return true;
        }

        int[,] graph = new int[n, n];
        
        for (int i = 0; i < edges.Length; i++)
        {
            graph[edges[i][0], edges[i][1]] = 1;
            graph[edges[i][1], edges[i][0]] = 1;
        }
        
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(source);
        
        while (queue.Count != 0)
        {
            int node = queue.Dequeue();
            if (node == destination)
            {
                return true;
            }

            for (int i = 0; i < n; i++)
            {
                if (graph[node, i] == 1)
                {
                    queue.Enqueue(i);
                    graph[node, i] = 0;
                }
            }
        }

        return false;
    }
}