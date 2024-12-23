using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Logic
{
    internal class DoubleNode<T>
    {
        public T? Data { get; set; }
        public DoubleNode<T>? Left { get; set; }
        public DoubleNode<T>? Right { get; set; }
        public DoubleNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
