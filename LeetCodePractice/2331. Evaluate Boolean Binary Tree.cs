namespace LeetCodePractice;

public class p_2331_Evaluate_Boolean_Binary_Tree {
 //Definition for a binary tree node.
     public class TreeNode {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int val= 0, TreeNode left=null, TreeNode right=null) {
             this.val = val;
             this.left = left;
             this.right = right; }
     }
    
    public bool EvaluateTree(TreeNode root) {
        if (root.val == 2)
        {
            return EvaluateTree(root.left) || EvaluateTree(root.right);
        }

        if (root.val == 3)
        {
            return EvaluateTree(root.left) && EvaluateTree(root.right);
        }
        return root.val == 1 ? true : false;
    }

    public p_2331_Evaluate_Boolean_Binary_Tree()
    {
        
    }
}