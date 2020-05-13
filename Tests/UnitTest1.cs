using System;
using System.IO;
using AssetFinance.Services;
using AssetFinance.Interfaces;
using Xunit;


namespace Tests
{
    public class UnitTest1
    {
        public UnitTest1()
        {            
        }

        [Fact]
        public void Test1()
        {

            var content = 
            @"1
8 9
1 5 9
4 5 2 3";


            var reader = new TreeProvider();
            var pathFinder = new PathFinder();            
            var tree = reader.GetTree(content);            
            var res = pathFinder.FindPath(tree);
            Assert.Equal(16,res.Sum);
        }
    }
}
