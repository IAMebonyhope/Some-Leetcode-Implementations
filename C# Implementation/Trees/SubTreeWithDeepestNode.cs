using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class SubTreeWithDeepestNode
    {
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {

            return helper(root).node;
        }

        private Result helper(TreeNode root)
        {

            if (root == null)
            {
                return new Result(0, null);
            }

            Result left = helper(root.left);
            Result right = helper(root.right);

            if (left.depth > right.depth)
            {
                return new Result(1 + left.depth, left.node);
            }

            if (right.depth > left.depth)
            {
                return new Result(1 + right.depth, right.node);
            }

            return new Result(1 + left.depth, root);


        }
    }

    public class Result
    {

        public int depth;
        public TreeNode node;

        public Result(int depth, TreeNode node)
        {
            this.depth = depth;
            this.node = node;
        }
    }
}
