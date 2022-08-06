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
                Console.WriteLine("\nPlease select the Options from Below Use case to execute: ");
                Console.WriteLine("1.Create a simple Linked List of 56, 30 and 70");
                Console.WriteLine("2.Create Linked List by adding 30 and 56 to 70, LinkedList Sequence: 56->30->70");
                Console.WriteLine("3.Create Linked List by appending 30 and 70 to 56, LinkedList Sequence: 56->30->70");
                Console.Write("4.Exit  ");
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
                    case 2:
                        LinkedList<int> linkedListObj2 = new LinkedList<int>();
                        linkedListObj2.AddFirst(70);
                        linkedListObj2.AddFirst(30);
                        linkedListObj2.AddFirst(56);
                        linkedListObj2.Display();
                        break;
                    case 3:
                        LinkedList<int> linkedListObj3 = new LinkedList<int>();
                        linkedListObj3.Append(56);
                        linkedListObj3.Append(30);
                        linkedListObj3.Append(70);
                        linkedListObj3.Display();
                        Console.WriteLine();
                        break;
                }
            } while (option != 4);


        }
    }
}