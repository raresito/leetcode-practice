namespace LeetCodePractice;

public class p_826_Most_Profit_Assigning_Work {
    
    //Can be improved by using Binary Search and sorting the arrays
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        int totalProfit = 0;
        foreach (int worke in worker)
        {
            int maxProfitPoz = -1;
            for(int i = 0; i < profit.Length; i++)
            {
                if (maxProfitPoz == -1 )
                {
                    if (difficulty[i] <= worke)
                    {
                        maxProfitPoz = i;
                    }
                } else if (profit[i] > profit[maxProfitPoz])
                {
                    if (difficulty[i] <= worke)
                    {
                        maxProfitPoz = i;
                    }
                }
            }
            if(maxProfitPoz > -1)
            {
                totalProfit += profit[maxProfitPoz];
            }
        }

        return totalProfit;
    }
    
    public p_826_Most_Profit_Assigning_Work()
    {
        // int[] difficulty = [85, 47, 57];
        // int[] profit = [24, 66, 99];
        // int[] worker = [40, 25, 25];
        
        int[] difficulty = [2,4,6,8,10];
        int[] profit = [10,20,30,40,50];
        int[] worker = [4,5,6,7];

        Console.WriteLine(MaxProfitAssignment(difficulty, profit, worker));
    }
}