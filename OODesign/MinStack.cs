using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
    //Site: LeetCode
    //Category: Top Interview Questions(BloomBerg)
    //Difficulty: Easy 
    public class MinStack
    {

        /** initialize your data structure here. */
        Stack<int> stack;
        Stack<int> minStack;

        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int x)
        {
            stack.Push(x);
            if ((minStack.Count == 0) || (minStack.Peek() >= x))
            {
                minStack.Push(x);
            }
        }

        public void Pop()
        {
            int popped = stack.Pop();
            if ((minStack.Count > 0) && (minStack.Peek() == popped))
            {
                minStack.Pop();
            }
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
