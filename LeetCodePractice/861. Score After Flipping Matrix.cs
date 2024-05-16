namespace LeetCodePractice;

public class p_861_Score_After_Flipping_Matrix {
    
    private int sumadecoloana(int j, int[][] grid)
    {
        int s = 0;
        for (int k = 0; k < grid.Length; k++)
        {
            s = s + grid[k][j];
        }

        return s;
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
    
    public int MatrixScore(int[][] grid) {
        for(int i = 0; i < grid.Length; i++){
            if(grid[i][0] == 0){
                for (int k = 0; k < grid[0].Length; k++)
                {
                    grid[i][k] = grid[i][k] == 0 ? 1 : 0;
                }
            }
        }

        for(int j = 1; j < grid[0].Length; j++){
            if((float)sumadecoloana(j, grid)/grid.Length<0.5){
                for (int k = 0; k < grid.Length; k++)
                {
                    grid[k][j] = grid[k][j] == 0 ? 1 : 0;
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
        for (int i = 0; i < grid.Length; i++)
        {
            result = result + calculBinar(i, grid);
        }
        return result;

    }

    

    public p_861_Score_After_Flipping_Matrix()
    {
        int[][] exemplu1 = [[0, 0, 1, 1], [1, 0, 1, 0], [1, 1, 0, 0]];
        Console.WriteLine(MatrixScore(exemplu1));
    }
}