using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject
{
    internal class VectorStack : IStackADT<int>
    {
        private ArrayBasedVector<int> mStack = new ArrayBasedVector<int>();

        public int Size => mStack.Size;

        public int Peek()
        {
            if ((Size - 1) < 0)
                throw new ArgumentOutOfRangeException("nothing in stack");
            return mStack.ElementAtRank(Size - 1);
        }

        public int Pop()
        {
            if ((Size - 1) < 0)
                throw new ArgumentOutOfRangeException("nothing in stack");
            return mStack.RemoveElementAtRank(Size - 1);
        }

        public void Push(int item)
        {
            mStack.Append(item);
        }
    }
}
