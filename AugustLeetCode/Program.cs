using System;
using LeetCode.DepthOfBinaryTree;

namespace AugustLeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            DepthOfBinaryTreeSolution solution=new DepthOfBinaryTreeSolution();
            TreeNode node = new TreeNode()
            {
                val = 3,
                left = new TreeNode {val = 9},
                right = new TreeNode {val = 20, right = new TreeNode {val = 7}, left = new TreeNode() {val = 15}}
            };
           
            Console.WriteLine(solution.MaxDepth(node));

        }
    }
}
