using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class IsValidBST
    {
        public bool isValidBST(TreeNode root)
        {
            return inorderCheck(root, int.MinValue);
            //return checkBST(root, int.MaxValue, int.MinValue);
        }

        private bool checkBST(TreeNode node, long largest, long smallest){
             if(node == null){
                 return true;
             }

             if(((largest != int.MinValue) && (node.val >= largest)) || ((smallest != int.MaxValue) && (node.val <= smallest))){
                 return false;
             }

             return (checkBST(node.left, node.val, smallest) && checkBST(node.right, largest, node.val));
         }

        public bool inorderCheck(TreeNode node, Stack<int> stack)
        {

            if (node == null)
            {
                return true;
            }

            bool left = inorderCheck(node.left, stack);
            if ((stack.Count == 0) || (node.val > stack.Peek()))
            {
                stack.Push(node.val);
            }
            else
            {
                return false;
            }
            bool right = inorderCheck(node.right, stack);

            return left && right;

        }
    }
}
