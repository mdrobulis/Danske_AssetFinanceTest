using System;
using System.IO;
using AssetFinance.Services;
using AssetFinance.Interfaces;

namespace AssetFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length!=1)
             Console.WriteLine("Usage: ./dotnet run test.txt ");
            var content = File.ReadAllText(args[0]);
            //var content = File.ReadAllText("test.txt");

            ITreeProvider treeReader = new TreeProvider();
            IPathFinder pathFinder = new PathFinder();            
            var tree =treeReader.GetTree(content);

            var res = pathFinder.FindPath(tree);

            Console.WriteLine(content);
            Console.WriteLine("Output:");
            Console.WriteLine("Max Sum {0}",res.Sum);
            Console.Write("Path: ");
            Console.WriteLine(String.Join(", ",res.Path));
            
        }
    }
}
