using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AssetFinance.Data;
using AssetFinance.Interfaces;

namespace AssetFinance.Services
{
    public class PathFinder : IPathFinder
    {
        public Result FindPath(TreeNode tree)
        {
            paths = new List<List<int>>();
            AllPaths(tree,new List<int>());
            
            var results =paths.Select(path=>new Result(){Path=path,Sum = path.Aggregate((x,y)=> {return x + y;}
         ) } );
            var top =results.OrderByDescending(x=>x.Sum).First();
            return top;

        }

        private bool even(int val)
        {
            if(val % 2 == 0)
            return true;
            return false;
        }

        private bool odd(int val)
        {
            if(even(val))
            return false;
            return true;
        }

        List<List<int>> paths = new List<List<int>>();

        public void AllPaths(TreeNode node, List<int> currentPath,bool? oddness =null)
        {           
            var isOdd=odd(node.Value);   

            if(oddness==null || oddness== true && isOdd ==false || oddness== false && isOdd ==true)
                currentPath.Add(node.Value);

            // bottom
            if(node.Bottom==null){
              paths.Add(currentPath);
              return;
            }

            AllPaths(node.Bottom,new List<int>(currentPath),isOdd);
            AllPaths(node.Left,new List<int>(currentPath),isOdd);
        }
        

    }
}
