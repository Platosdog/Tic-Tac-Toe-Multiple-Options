using System;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?:");
            var name = Console.ReadLine();
            Console.WriteLine($"Hi {name}, welcome to Tic Tac Toe.");
            int friends = 0;
            while (friends == 0)
            {
                Console.WriteLine($"How many friends want to play with you {name}?:");
                if (!int.TryParse(Console.ReadLine(), out friends))
                {
                    Console.WriteLine($"Please use a number, {name}, you do know what a number is right?");
                }
            }
                Console.WriteLine($"So you have {friends} friends that wants to play with you?");
            int columns = 0;
            while (columns == 0)
            {
                Console.WriteLine($"How many columns do you want {name}?");
                if (!int.TryParse(Console.ReadLine(), out columns))
                {
                    Console.WriteLine($"Please use a number, {name}, you do know what a number is right?");
                }
            }
            Console.WriteLine($"So you would like {columns} columns {name}");

            int rows = 0;
            while (rows == 0)
            {
                Console.WriteLine($"How many rows do you want {name}?");
                if (!int.TryParse(Console.ReadLine(), out rows))
                {
                    Console.WriteLine($"Please use a number, {name}, you do know what a number is right?");
                }
            }
            Console.WriteLine($"So you would like {rows} rows {name}");
            Console.WriteLine($"{name} please give me a second to draw out the game board");

            for (int r = 0; r < rows; r++)
            {
                Console.Write("|");
                for (int c = 0; c < columns; c++)
                {
                    Console.Write("__|");
                }
                Console.WriteLine();
            }  
        }
    }
}
