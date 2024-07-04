/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root == null)
            return 0;

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }

    public int RecursiveIteration(TreeNode node){
        var height = 1;
        var leftHeight = 0;
        var rightHeight = 0;

        if(node.left != null){
            leftHeight += RecursiveIteration(node.left);
        }
        if(node.right != null){
            rightHeight += RecursiveIteration(node.right);
        }

        if(leftHeight > rightHeight)
            height += leftHeight;
        else
            height += rightHeight;
        
        return height;
    }
}