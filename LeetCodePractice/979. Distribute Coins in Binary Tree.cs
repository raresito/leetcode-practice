namespace LeetCodePractice;

public class p_979_Distribute_Coins_in_Binary_Tree {

    public Tuple<int, int> Distribute2(TreeNode root)
    {
        if (root == null) return null;

        Tuple<int, int> leftConclusion = Distribute2(root.left);
        Tuple<int, int> rightConclusion = Distribute2(root.right);
        // Item1 - Number of transitions needed;
        // Item2 - Number of coins present;

        if (root.left == null && root.right == null)
        {
            if (root.val == 0)
            {
                return new Tuple<int, int>(1, root.val - 1);
            }

            return new Tuple<int, int>(root.val - 1, root.val - 1);
        }

        if (rightConclusion is null)
        {
            rightConclusion = new Tuple<int, int>(0, 0);
        }

        if (leftConclusion is null)
        {
            leftConclusion = new Tuple<int, int>(0, 0);
        }

        // Calculate coins present in this node
        int extraCoins = leftConclusion.Item2 + rightConclusion.Item2 + root.val - 1;

        int transitionsResult = 1;
        // Calculate transitions needed from parent
        if (extraCoins < 0 && root.val == 0)
        {
            // transitionsResult = Math.Abs(leftConclusion.Item2) + Math.Abs(rightConclusion.Item2) + leftConclusion.Item1 + rightConclusion.Item1 + 1;
            transitionsResult = leftConclusion.Item1 + rightConclusion.Item1 + Math.Abs(extraCoins);
        }
        

        if (extraCoins < 0 && root.val != 0)
        {
            transitionsResult = Math.Abs(extraCoins) + leftConclusion.Item1 + rightConclusion.Item1;
            // transitionsResult = leftConclusion.Item1 + rightConclusion.Item1 + 1;
        }

        if (extraCoins == 0 && root.val != 0)
        {
            transitionsResult = leftConclusion.Item1 + rightConclusion.Item1;
        }

        if (extraCoins == 0 && root.val == 0)
        {
            transitionsResult = leftConclusion.Item1 + rightConclusion.Item1;
        }

        if (extraCoins > 0 && root.val != 0)
        {
            transitionsResult = leftConclusion.Item1 + rightConclusion.Item1 + extraCoins;
        }

        if (extraCoins > 0 && root.val == 0)
        {
            transitionsResult = leftConclusion.Item1 + rightConclusion.Item1 + extraCoins;
        }
        
        return new Tuple<int, int>(transitionsResult, extraCoins);
    }
    public int DistributeCoins(TreeNode root)
    {
        Tuple<int, int> result = Distribute2(root);
        return result.Item1;
    }

    public p_979_Distribute_Coins_in_Binary_Tree()
    {
        
    }
}