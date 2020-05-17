using System;
using System.IO;
using System.Linq;
using AssetFinance.Data;
using AssetFinance.Interfaces;
using System.Collections.Immutable;
using Priority_Queue;


namespace AssetFinance.Services
{
    public class PrioriryPathFinder : IPathFinder
    {

        
        public Result FindPath(TreeNode tree)
        {
            var results = new SimplePriorityQueue<ImmutableList<int>>();            
            
            
            AllPaths(tree,ImmutableList<int>.Empty,ref results);
            var winner = results.Dequeue();
            return new Result(){Path=winner.ToList(),Sum = winner.Aggregate((x,y)=> {return x + y;}) };         

        }
        

        private bool odd(int val)
        {
            if(val % 2 == 0)
            return false;
            return true;
        }        


        float priority(ImmutableList<int> path){
            var sum = path.Aggregate((x,y)=> {return x + y;});

            return sum * -1f; // cuz this priority queue deques item with minimum priority.
        }



        public void AllPaths(TreeNode node, ImmutableList<int> currentPath, ref SimplePriorityQueue<ImmutableList<int>> queue ,bool? oddness =null)
        {           
            var isOdd=odd(node.Value);
            ImmutableList<int> path =currentPath;

            if(oddness==null || oddness== true && isOdd ==false || oddness== false && isOdd ==true)
                 path = currentPath.Add(node.Value);

            // bottom
            if(node.Bottom==null){
              queue.Enqueue(path,path.Aggregate((x,y)=> {return x + y;}) * -1 );
              return;
            }
            AllPaths(node.Bottom,path, ref queue ,isOdd);
            AllPaths(node.Left,path, ref queue ,isOdd);
        }
        

    }
}
