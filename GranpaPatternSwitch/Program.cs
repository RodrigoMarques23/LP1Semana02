using System;

namespace GranpaPatternSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Place your question? ");
            string opcao = Console.ReadLine();


            //string opcao;
            string message = opcao switch
            {

                "How are you" => "I'm fine, thank you",
                "What's your name?" => "Gran'pa",
                "What's your mission?" => "Destroy mankind!",
                null => "You got me, I'm not THAT smart!",
                _ => "Not possible"
            };

            Console.WriteLine(message);
        }
    }
}
