using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class HeightOfBinaryTree
    {
        public int height(TreeNode root)
        {
            return helper(root);
        }

        public int helper(TreeNode root)
        {
            if(root == null)
            {
                return -1;
            }

            int left = 1 + helper(root.left);
            int right = 1 + helper(root.right);

            return Math.Max(left, right);
        }
    }
}
