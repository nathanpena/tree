using System;
using System.Collections.Generic;
using System.Text;

namespace nodeProj.models
{
    class Tree
    {
        public Node root = null;
        public int add = 0;

        public void insert(int x)
        {
            if (root == null)
            {
                add++;
                this.root = new Node(x);
            }
            else
            {
                recInsert(ref this.root, x);
            }

        }

        void recInsert(ref Node root, int x)
        {
            Node n = new Node(x);
            if (root == null)
            {
                add++;
                root = n;
            }
            else
            {
                if (root.Data >= x)
                {
                    recInsert(ref root.Left, x);
                }
                else
                {
                    recInsert(ref root.Right, x);
                }
            }

        }

        public void Display()
        {
            recDisplay(ref this.root);
        }

        void recDisplay(ref Node root)
        {
            if (root == null)
            {
                //do nothing
            }
            else
            {
                Console.WriteLine(root.Data.ToString());
                recDisplay(ref root.Left);
                recDisplay(ref root.Right);
            }
        }

        public int height(ref Node n)
        {
            if (n == null)
            {
                return -1;
            }
            else
            {
                return recHeight(n,0);
            }
        }

        int recHeight(Node n, int total)
        {
            if (n == null || n.Left == null && n.Right == null)
            {
                total = 0;
            }
            else
            {
                if(total != 0)
                {
                    total += 1;
                }
                int l = recHeight(n.Left, total);
                int r = recHeight(n.Right, total);

                if(l > r)
                {
                    total = l + 1;
                } else
                {
                    total = r + 1;
                }
            }

            return total;
        }
    }
}
