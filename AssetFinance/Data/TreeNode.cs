namespace AssetFinance.Data
{
    public class TreeNode
    {
        public TreeNode(int val, TreeNode bottom, TreeNode left)
        {
            Value =val;
            Bottom = bottom;
            Left = left;
        }
        public readonly  int Value;
        public readonly TreeNode Bottom;
        public readonly TreeNode Left;

    }
}