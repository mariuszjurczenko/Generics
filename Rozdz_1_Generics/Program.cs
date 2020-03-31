using System;

namespace Rozdz_1_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new MyStack<double>();

            while (true)
            {
                int choice = DisplayMenu();
                WorkWithAChoice(collection, choice);
                BackToMenu();
            }
        }
     
        private static int DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("\nMenu : ");
            Console.WriteLine();
            Console.WriteLine("1. Write element");
            Console.WriteLine("2. Read element");
            Console.WriteLine("3. Check element");
            Console.WriteLine("4. Display all");
            Console.WriteLine("5. End of program");
            Console.WriteLine();
            Console.Write("Chose what you want to do: ");
            int.TryParse(Console.ReadLine(), out int choice);
            return choice;
        }

        private static void WorkWithAChoice(IMyCollection<double> collection, int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Write element : ");
                    if (double.TryParse(Console.ReadLine(), out double value))
                        collection.WriteElement(value);
                    break;
                case 2:
                    Console.WriteLine("This element readed : {0}", collection.ReadElement());
                    break;
                case 3:
                    Console.WriteLine("The output element is : {0}", collection.CheckElement());
                    break;
                case 4:
                    collection.DisplayAll();
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("You made the wrong choice !");
                    break;
            }
        }

        private static void BackToMenu()
        {
            Console.WriteLine("Press enter to go to the menu");
            Console.ReadKey();
        }
    }
}
