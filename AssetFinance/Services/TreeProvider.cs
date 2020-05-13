using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AssetFinance.Data;
using AssetFinance.Interfaces;

namespace AssetFinance.Services
{
    public class TreeProvider : ITreeProvider
    {
       
        public TreeNode GetTree(string content)
        {
            var lines = content.Split("\n");
            var numberTree = ReadNumbersTree(lines);
            return BuildTree(numberTree,0, 0);

        }

        public int[][] ReadNumbersTree(string[] lines)
        {
            int[][] res = new int[lines.Length][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = lines[i].Split(" ").Select(int.Parse).ToArray();
            }
            return res;

        }

        private TreeNode BuildTree(int[][] tree, int lineIndex, int numberIndex)
        {
            int val = tree[lineIndex][numberIndex];

            // bottom row
            if (lineIndex == tree.Length - 1)
            {
                return new TreeNode(val, null, null);
            }
            else
            {

                var downTree = BuildTree(tree, lineIndex + 1, numberIndex);
                var leftTree = BuildTree(tree, lineIndex + 1, numberIndex + 1);
                return new TreeNode(val, downTree, leftTree);

            }

        }

    }
}
