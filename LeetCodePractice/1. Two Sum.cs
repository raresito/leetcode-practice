namespace LeetCodePractice;

public class p_1_Two_Sum {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> p = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (p.ContainsKey(nums[i]))
            {
                return [(int)p[nums[i]], i];
            }
            else
            {
                if (!p.ContainsKey(target - nums[i]))
                {
                    p.Add(target - nums[i], i);
                }
            }
        }

        return [];
    }

    public p_1_Two_Sum()
    {
        int[] example1 = [2, 7, 11, 15];
        int target1 = 9;
        int[] example2 = [3, 2, 4];
        int target2 = 6;
        int[] example3 = [3, 3];
        int target3 = 6;
        int[] example4 = [1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1];
        int target4 = 11;
        // int[] result = TwoSum(example1, target1);
        // int[] result = TwoSum(example2, target2);
        // int[] result = TwoSum(example3, target3);
        int[] result = TwoSum(example4, target4);
        foreach(var item in result)
        {
            Console.WriteLine(item);
        }
    }
}