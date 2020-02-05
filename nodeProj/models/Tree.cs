using System;
using System.Collections.Generic;
using System.Text;

namespace nodeProj.models
{
    class Tree
    {
        Node root = null;

        public void insert(int x)
        {
            if(root == null)
            {
                this.root = new Node(x);
            } else
            {
                recInsert(ref this.root, x);
            }
            
        }

        void recInsert(ref Node root, int x)
        {
            if(root == null)
            {
                //do nothing
            } else
            {
                if (this.root.Data > x)
                {
                    recInsert(ref root.Left, x);
                    root.Left = new Node(x);
                }
                else
                {
                    recInsert(ref root.Right, x);
                    root.Right = new Node(x);
                }
            }
        }

        public void Display()
        {
            if(root == null)
            {
                //do nothing
            } else
            {
                recDisplay(ref this.root);
            }
        }

        void recDisplay(ref Node root)
        {
            if (root == null)
            {
                //do nothing
            }
            else
            {
                recDisplay(ref root.Left);
                Console.WriteLine(root.Data.ToString());
                recDisplay(ref root.Right);
            }
        }

    }
}
