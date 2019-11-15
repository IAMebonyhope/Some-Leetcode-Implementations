using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class LowestCommonAncestorBST
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {

            return helper(root, p, q);

        }

        private TreeNode helper(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }

            else if ((root.val < p.val) && (root.val < q.val))
            {
                return helper(root.right, p, q);
            }

            else if ((root.val > p.val) && (root.val > q.val))
            {
                return helper(root.left, p, q);
            }

            else if ((root.val >= p.val) && (root.val <= q.val))
            {
                return root;
            }

            else if ((root.val <= p.val) && (root.val >= q.val))
            {
                return root;
            }

            return null;
        }
    }
}
