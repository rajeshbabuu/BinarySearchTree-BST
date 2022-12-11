namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n************* WELCOME TO BINARY SEARCH TREE(BST) ******************");

            Binary<int> binary = new Binary<int>(56);
            binary.Add(30);
            binary.Add(70);
            binary.Display();
            Console.ReadKey();
        }
    }
}