﻿using System;

namespace LeetCode.DepthOfBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class DepthOfBinaryTreeSolution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);
            return 1 + Math.Max(left, right);
        }
    }
}