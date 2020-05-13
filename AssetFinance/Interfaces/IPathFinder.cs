using AssetFinance.Data;

namespace AssetFinance.Interfaces
{
    public interface IPathFinder
    {
         Result FindPath(TreeNode tree);
    }
}