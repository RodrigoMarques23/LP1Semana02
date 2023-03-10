using System;

namespace CrossSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int userInput = Convert.ToInt32(args[0]);

            for(int i = 0; i < userInput; i++)
            {
                for(int j = 0; j < userInput; j++)
                    if(i  == 0 || i == userInput - 1 || j == 0 ||
                        j == userInput           - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        if(userInput < 7) Console.Write(" ");
                        else
                            Console.Write(j - i == 0 || j + i == userInput - 1 ?
                                "X" : " ");
                    }

                Console.WriteLine();
            }
        }
    }
}
