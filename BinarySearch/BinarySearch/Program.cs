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
            binary.Add(22);
            binary.Add(40);
            binary.Add(60);
            binary.Add(95);
            binary.Add(11);
            binary.Add(65);
            binary.Add(3);
            binary.Add(16);
            binary.Add(63);
            binary.Add(67);
            binary.Display();
            binary.GetSize();
            Console.ReadKey();

            bool result = binary.IfExists(63, binary);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}