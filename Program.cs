using System;

namespace Higherorlower
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int luckyNumber1 = r.Next(0, 9);
            int luckyNumber2 = r.Next(0, 9);
            bool lose = false;
            int guessedRight = 0;
            bool secondTry = false;
            bool restart = false;

             

            Console.WriteLine("Welcome to Higher or Lower");

            Console.WriteLine("You are shown a random number between 0-9, and you need to guess if the next number will be lower och higher");
            Console.WriteLine("write higher if you think the next number will be higher, or lower if you think the next number will be lower");
            Console.WriteLine("you number is " + luckyNumber1);

            do
            {
                restart = false;
                Console.WriteLine("Is the next one higher or lower ? ");
                string a = Console.ReadLine();


                if (luckyNumber1 < luckyNumber2 && a == "higher" && secondTry == false)
                {
                    Console.WriteLine("Correct, the number was " + luckyNumber2);
                    guessedRight++;
                    Console.WriteLine("you number is " + luckyNumber2);
                    luckyNumber1 = r.Next(0, 9);
                    secondTry = true;
                }
                else if (luckyNumber1 > luckyNumber2 && a == "lower" && secondTry == false)
                {
                    Console.WriteLine("Correct, the number was " + luckyNumber2);
                    guessedRight++;
                    Console.WriteLine(" you number is " + luckyNumber2);
                    luckyNumber1 = r.Next(0, 9);
                    secondTry = true;
                }
                else if (luckyNumber2 < luckyNumber1 && a == "higher" && secondTry == true)
                {
                    Console.WriteLine("Correct, the number was " + luckyNumber1);
                    guessedRight++;
                    Console.WriteLine(" you number is " + luckyNumber1);
                    luckyNumber2 = r.Next(0, 9);
                    secondTry = false;
                }
                else if (luckyNumber2 > luckyNumber1 && a == "lower" && secondTry == true)
                {
                    Console.WriteLine("Correct, the number was " + luckyNumber1);
                    guessedRight++;
                    Console.WriteLine(" you number is " + luckyNumber1);
                    luckyNumber2 = r.Next(0, 9);
                    secondTry = false;
                }
                else if (luckyNumber1 == luckyNumber2 && secondTry == false)
                {
                    Console.WriteLine("they are the same number, guess again");
                    luckyNumber2 = r.Next(0, 9);
                }
                else if (luckyNumber1 == luckyNumber2 && secondTry == true)
                {
                    Console.WriteLine("they are the same number, guess again");
                    luckyNumber1 = r.Next(0, 9);
                }
                else if (a != "higher" && a != "lower")
                {
                    Console.WriteLine("Your spelling is questionable...");
                }
                else if (restart == true)
                {
                    Console.WriteLine("Welcome to Higher or Lower");

                    Console.WriteLine("You are shown a random number between 0-9, and you need to guess if the next number will be lower och higher");
                    Console.WriteLine("write higher if you think the next number will be higher, or lower if you think the next number will be lower");
                    Console.WriteLine("you number is " + luckyNumber1);
                    return;



                }

                else
                {
                    Console.WriteLine("sorry incorrect. The numbers were " + luckyNumber2 + " and " +
                        "" + luckyNumber1);
                    Console.WriteLine("you guessed correct " + guessedRight + " times!");
                    break;


                    
                }
               





            } while (lose == false);

           
        }
    }
}
