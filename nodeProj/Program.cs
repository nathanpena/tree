using nodeProj.models;
using System;

namespace nodeProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.insert(3);
            tree.insert(10);
            tree.insert(2);
            tree.insert(5);
            tree.insert(6);
            tree.insert(4);
            tree.Display();
        }
    }
}
