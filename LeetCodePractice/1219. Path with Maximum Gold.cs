using System.Net;
using System.Threading.Tasks.Dataflow;

namespace LeetCodePractice;

public class p_1219_Path_with_Maximum_Gold {

    public int maxValue(int[][] grid, int i, int j)
    {
        int gold = grid[i][j];
        if (gold == 0)
        {
            return 0;
        }
        grid[i][j] = 0;
        int up = 0;
        int left = 0;
        int right = 0;
        int down = 0;
        if (i != 0)
        {
            int[][] localGrid = grid.Select(a => (int[])a.Clone()).ToArray();
            up = maxValue(localGrid, i - 1, j); 
        }

        if (j != 0)
        {
            int[][] localGrid = grid.Select(a => (int[])a.Clone()).ToArray();
            left = maxValue(localGrid, i, j-1);
        }

        if (i != grid.Length - 1)
        {
            int[][] localGrid = grid.Select(a => (int[])a.Clone()).ToArray();
            down = maxValue(localGrid, i + 1, j);
        }

        if (j != grid[0].Length - 1)
        {
            int[][] localGrid = grid.Select(a => (int[])a.Clone()).ToArray();
            right = maxValue(localGrid, i, j + 1);
        }
        return gold + Math.Max(Math.Max(Math.Max(up, down), left),right);
    }

    public int GetMaximumGold(int[][] grid)
    {
        int max = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {

                int[][] localGrid = grid.Select(a => (int[])a.Clone()).ToArray();
                int maximumHere = maxValue(localGrid, i, j);
                Console.WriteLine(maximumHere + " ");
                if (max < maximumHere)
                {
                    max = maximumHere;
                }
            }

            Console.WriteLine();
        }

        return max;
    }
    
    public p_1219_Path_with_Maximum_Gold()
    {
        int[][] exemplu1 = [[1,0,7],[2,0,6],[3,4,5],[0,3,0],[9,0,20]];
        int[][] exemplu2 = [[0,0,0,22,0,24],[34,23,18,0,23,2],[11,39,20,12,0,0],[39,8,0,2,0,1],[19,32,26,20,20,30],[0,38,26,0,29,31]];
        int[][] exemplu3 = [[1, 1, 1, 1, 1], [1, 1, 1, 1, 1], [1, 1, 1, 1, 1], [1, 1, 1, 1, 1], [1, 1, 1, 1, 1]];
        Console.WriteLine(GetMaximumGold(exemplu3));
    }
}