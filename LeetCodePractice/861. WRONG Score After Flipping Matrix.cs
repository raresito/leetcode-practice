public class p_861_WRONG_Score_After_Flipping_Matrix {
    private int sumadelinie(int i, int[][] grid)
    {
        int s = 0;
        for (int k = 0; k < grid[0].Length; k++)
        {
            s = s + grid[i][k];
        }

        return s;
    }
    private int sumadecoloana(int j, int[][] grid)
    {
        int s = 0;
        for (int k = 0; k < grid.Length; k++)
        {
            s = s + grid[k][j];
        }

        return s;
    }
    private int[][] fliplinia(int i, int[][] grid){
        for (int k = 0; k < grid[0].Length; k++)
        {
            grid[i][k] = grid[i][k] == 0 ? 1 : 0;
        }
        
        return grid;
    }
    private int[][] flipcoloana(int j, int[][] grid){
        for (int k = 0; k < grid.Length; k++)
        {
            grid[k][j] = grid[k][j] == 0 ? 1 : 0;
        }
        
        return grid;
    }
    public int MatrixScore(int[][] grid) {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    if((float)sumadelinie(i, grid)/grid[i].Length < (float)sumadecoloana(j, grid)/grid.Length)
                    {
                        fliplinia(i, grid);
                    } 
                    else
                    {
                        flipcoloana(j, grid);
                    }
                }
            }
        }
        
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                Console.Write(grid[i][j] + " ");
            }
            Console.WriteLine();
        }
        
        int result = 0;
        // for (int i = 0; i < grid.Length; i++)
        // {
        //     result = result + sumadelinie(i, grid);
        // }
        
        // Result for the actual problem:
        for (int i = 0; i < grid.Length; i++)
        {
            result = result + calculBinar(i, grid);
        }
        return result;

    }

    private int calculBinar(int i, int[][] grid)
    {
        int result = 0;
        
        for (int j = 0; j < grid[0].Length; j++)
        {
            result = result + grid[i][j] * (int)Math.Pow(2, grid[0].Length - j - 1);
        }

        return result;
    }

    public p_861_WRONG_Score_After_Flipping_Matrix()
    {
        int[][] exemplu1 = [[0, 0, 1, 1], [1, 0, 1, 0], [1, 1, 0, 0]];
        Console.WriteLine(MatrixScore(exemplu1));
    }
}