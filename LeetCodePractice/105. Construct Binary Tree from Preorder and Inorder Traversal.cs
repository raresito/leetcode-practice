using System.Xml.Xsl;

namespace LeetCodePractice;

public class p_105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal {

    public class TreeNode {
         public int val;
             public TreeNode left;
             public TreeNode right;
             public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                 this.val = val;
                 this.left = left;
                 this.right = right;
             }
     }

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        TreeNode left = null;
        TreeNode right = null;
        int root = preorder[0];
        for (int i = 0; i < inorder.Length; i++)
        {
            if (inorder[i] == root)
            {
                if (preorder.Length == 1 && inorder.Length == 1)
                {
                    return new TreeNode(root);
                }
                if (preorder.Length == 2 && inorder.Length == 2)
                {
                    if (i == 1)
                    {
                        return new TreeNode(root, new TreeNode(inorder[0]), null);
                    }
                    else
                    {
                        return new TreeNode(root, null, new TreeNode(inorder[1]));
                    }
                }
                int[] leftinorder = inorder[0..i];
                int endleftpreorder = leftinorder.Length + 1;
                int[] leftpreorder = preorder[1..endleftpreorder];
                if (leftpreorder.Length == 0)
                {
                    left = null;
                }
                else
                {
                    left = BuildTree(leftpreorder, leftinorder);
                }
                
                
                int rightinorderstart = i + 1;
                if (rightinorderstart >= preorder.Length)
                {
                    right = null;
                }
                else
                {
                    int[] rightinorder = inorder[rightinorderstart..inorder.Length];
                    int rightpreorderstart = 1 + leftpreorder.Length;
                    int[] rightpreorder = preorder[rightpreorderstart..preorder.Length];
                    right = BuildTree(rightpreorder, rightinorder);
                }
                

            }
        }

        return new TreeNode(root, left, right);
    }

    public p_105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal()
    {
        // TreeNode result = BuildTree([3,9,20,15,7], [9,3,15,20,7]);
        // TreeNode result = BuildTree([1,2], [2,1]);
        // TreeNode result = BuildTree([1,2,3], [3,2,1]);
        TreeNode result = BuildTree([1,2,3], [1,2,3]);
        
    }
}