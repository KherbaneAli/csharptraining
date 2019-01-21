using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharptraining
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllLines("treesnew.csv",File.ReadAllLines(@"\_git\csharptraining\data\trees.csv").Where(l => !string.IsNullOrWhiteSpace(l)));
            
            var treeData = File.ReadAllLines(@"\_git\csharptraining\treesnew.csv");
        
            var treeList = from treeInfo in treeData
                    let data = treeInfo.Split(',')
                    select new
                    {
                        Index = data[0],
                        Girth = data[1],
                        Height= data[2],
                        Volume = data[3],
                    };
                    
            foreach (var tree in treeList)
            {
                Console.WriteLine("|" + tree.Index + "|" + tree.Girth + "|" + tree.Height + "|" + tree.Volume + "|");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}