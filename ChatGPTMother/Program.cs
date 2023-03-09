using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine("Make me a question!");
                string question = Console.ReadLine();

                //Switch case
                string answer = question switch
                {
                    "Are you a robot?" => "Hummmm, maybe",
                    "Can you have feelings?" => "Of course",
                    "What your goal here?" => "Talking to you",
                    "Do you need to sleep?" => "Sometimes",
                    "EXIT" => "Goodbye my friend",
                    null => "Can't answer that sorry",
                    _ => "What are you trying to write?",

                };
                Console.WriteLine(answer);

                //Break Verification
                if (question == "EXIT")
                {
                    run = false;
                }
                else
                    continue;
            }
        }
    }
}
