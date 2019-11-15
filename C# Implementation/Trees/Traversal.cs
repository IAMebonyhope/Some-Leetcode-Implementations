using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Traversal
    {
        public void InOrder(Node node)
        {
            if(node == null)
            {
                return;
            }

            InOrder(node.Left);
            Visit(node);
            InOrder(node.Right);
        }

        public void PreOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            Visit(node);
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void PostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            PostOrder(node.Left);
            PostOrder(node.Right);
            Visit(node);
        }

        private void Visit(Node node)
        {
            Console.WriteLine(node.Value);
        }
    }
}
