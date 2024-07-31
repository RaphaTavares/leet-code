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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var list1 = new List<int>();
        var list2 = new List<int>();

        GetLeafValueSequence(root1, list1);
        GetLeafValueSequence(root2, list2);
        
        Console.WriteLine("list1: " + String.Join(", ", list1));
        Console.WriteLine("list2: " + String.Join(", ", list2));

        return list1.SequenceEqual(list2);
    }

    public void GetLeafValueSequence(TreeNode root, List<int> leafValueSequence)
    {
        var leftExists = root.left != null;
        var rightExists = root.right != null;

        if(leftExists) {
            Console.WriteLine("nó: " + root?.val);
            Console.WriteLine("indo para a esquerda");
            GetLeafValueSequence(root.left, leafValueSequence);
        }
        if(rightExists)
        {
            Console.WriteLine("nó: " + root?.val);
            Console.WriteLine("indo para a direita");
            GetLeafValueSequence(root.right, leafValueSequence);
        }
        if(!leftExists && !rightExists)
            leafValueSequence.Add(root.val);

        return;
    }
}