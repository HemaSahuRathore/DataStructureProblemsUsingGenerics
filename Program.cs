namespace LinkedListUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Welcome to the Linked List Data Structure Problems using C# Generics");

            do
            {
                Console.WriteLine("\nPlease select the Options from Below: ");
                Console.WriteLine("1.Create a simple Linked List of 56, 30 and 70");
                Console.Write("2.Exit  ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        LinkedList<int> linkedListObj = new LinkedList<int>();
                        linkedListObj.AddLast(56);
                        linkedListObj.AddLast(30);
                        linkedListObj.AddLast(70);
                        linkedListObj.Display();
                        Console.WriteLine();
                        break;
                }
            } while (option != 2);


        }
    }
}