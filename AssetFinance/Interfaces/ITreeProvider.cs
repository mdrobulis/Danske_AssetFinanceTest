using AssetFinance.Data;

namespace AssetFinance.Interfaces
{
    public interface ITreeProvider
    {
        TreeNode GetTree(string content);
    }
}