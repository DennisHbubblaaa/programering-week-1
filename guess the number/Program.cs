using System;


namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int guess = 0;
            string welcome = "Guess a number between 0 and 11";
            int num = rand.Next(1, 11);
            Console.WriteLine(welcome);


            int i = 0;

            while (guess != num)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > num)
                    {
                        Console.WriteLine("hahaha Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low sucker");
                    }
                }

                catch
                {
                    Console.WriteLine("Guess must be a number");
                    i--;
                }


                i++;
            }
            Console.WriteLine("Congrats, it took you " + i + " tries");
            Console.ReadLine();
        }
    }
}