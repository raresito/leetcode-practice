namespace LeetCodePractice;

public class p_1380_Lucky_Numbers_in_a_Matrix {
    public IList<int> LuckyNumbers (int[][] matrix)
    {
        int[] minimums = new int[matrix.Length];
        int[] maximums = new int[matrix[0].Length];
        List<int> result = new List<int>();

        int rowNum = 0;
        foreach (var row in matrix)
        {
            int min = row[0];
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] < min)
                {
                    min = row[i];
                }
            }

            minimums[rowNum] = min;
            rowNum++;
        }

        for (int j = 0; j < matrix[0].Length; j++)
        {
            int max = matrix[0][j];
            for (int i = 0; i < matrix.Length; i++)
            {
                if(matrix[i][j] > max)
                {
                    max = matrix[i][j];
                }
            }

            maximums[j] = max;
        }

        for (int i = 0; i < minimums.Length; i++)
        {
            for (int j = 0; j < maximums.Length; j++)
            {
                if (minimums[i] == maximums[j])
                {
                    result.Add(minimums[i]);
                }
            }
        }

        return result;
    }
    
    public p_1380_Lucky_Numbers_in_a_Matrix()
    {
        int[][] exemplu1 = [[3, 7, 8], [9, 11, 13], [15, 16, 17]];
        IList<int> response = LuckyNumbers(exemplu1);
        foreach (var VARIABLE in response)
        {
            Console.WriteLine(VARIABLE);
        }
    }
}