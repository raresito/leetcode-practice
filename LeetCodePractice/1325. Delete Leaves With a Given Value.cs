using System.Xml.Xsl;

namespace LeetCodePractice;

public class p_1325_Delete_Leaves_With_a_Given_Value {
    
    public TreeNode RemoveLeafNodes(TreeNode root, int target) {
        root.left = root.left is null ? null : RemoveLeafNodes(root.left, target);
        root.right = root.right is null ? null : RemoveLeafNodes(root.right, target);
        return root.left is null && root.right is null && root.val == target ? null : root;
    }
}