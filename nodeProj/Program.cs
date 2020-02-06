using nodeProj.models;
using System;

namespace nodeProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Console.WriteLine("empty tree");
            Console.WriteLine(tree.height(ref tree.root));
            tree.insert(3);
            Console.WriteLine("only root");
            Console.WriteLine(tree.height(ref tree.root));
            tree.insert(10);
            tree.insert(2);
            tree.insert(5);
            tree.insert(6);
            tree.insert(4);
            tree.insert(7);
            tree.insert(7);
            tree.insert(8);
            tree.Display();
            Console.WriteLine("New method call");
            Console.WriteLine(tree.height(ref tree.root));
        }
    }
}
