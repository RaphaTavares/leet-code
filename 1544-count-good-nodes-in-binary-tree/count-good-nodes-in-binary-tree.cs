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
    public int GoodNodes(TreeNode root) {

        return CountGoodNodes(root, int.MinValue);
    }

    public int CountGoodNodes(TreeNode root, int maxSoFar){
        if(root == null)
            return 0;

        int count = 0;
        
        if(root.val >= maxSoFar){
            Console.WriteLine($"nó " + root.val + "\nmaxSoFar: "+ maxSoFar);
            count = 1;
        }

        maxSoFar = Math.Max(root.val, maxSoFar);

        count += CountGoodNodes(root.left, maxSoFar);
        count += CountGoodNodes(root.right, maxSoFar);

        return count;
    }
}