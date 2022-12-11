using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Binary<T> where T : IComparable<T>
    {
        public T NodeData
        {
            get; set;
        }
        public Binary<T> leftTree { get; set; }
        public Binary<T> rightTree { get; set; }

        public Binary(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;

        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Add(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0) // "A".CompareTo("a")
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new Binary<T>(item);
                }
                else
                    this.leftTree.Add(item);

            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new Binary<T>(item);
                }
                else
                    this.rightTree.Add(item);
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
    }
}
