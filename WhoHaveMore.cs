using System;

internal class Program
{
 

    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int a_1 = 21;
        int a_2 =  24;
        int a_3 = 25;
        int a_4 = 23;
        int a_5 = 23;
        int menu = 0;

            Console.WriteLine("Welcome to 'Who have more'");
            Console.WriteLine("Do you want to play?");
            Console.WriteLine("1 - yes" + "  " + "2 - no");
         do
         {
            menu:
            menu = Convert.ToInt32(Console.ReadLine());  
            if(menu == 2)
            {
                break;
            }
            else if(menu != 1 && menu != 2)
            {
                Console.WriteLine("Folow the goddam instructions");
                Console.WriteLine("1 - yes" + " " + "2 - no");
                goto menu;
            }
        main:
            Console.WriteLine("Choose your variant:");
            Console.WriteLine($"1:6, 7, 8");
            Console.WriteLine($"2:7, 8, 9");
            Console.WriteLine($"3:6, 9, 10");
            Console.WriteLine($"4:6, 9, 8");
            Console.WriteLine($"5:7, 6, 10");

            int b = Convert.ToInt32(Console.ReadLine());
            if (b > 5 || b < 1)
            {
                Console.WriteLine("Please select correct variant");
                Console.WriteLine(" ");
                goto main;
            }

            Console.WriteLine("Please wait for computer to choose");
            Thread.Sleep(1000);
            int b_1 = rnd.Next(6, 11);
            int b_2 = rnd.Next(6, 11);
            int b_3 = rnd.Next(6, 11);
        Comp_1:
            if (b_2 == b_1)
            {
                b_2 = rnd.Next(6, 11);
                goto Comp_1;
            }
        Comp_2:
            if (b_3 == b_1 || b_3 == b_2)
            {
                b_3 = rnd.Next(6, 11);
                goto Comp_2;
            }

            int F_comp = b_1 + b_2 + b_3;

            Console.WriteLine($"{F_comp}");

            if (b == 1)
            {
                if (a_1 >= F_comp)
                {
                    Console.WriteLine("You are winner");
                }
                else if (a_1 == F_comp)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("You lose");
                }
            }
            if (b == 2)
            {
                if (a_2 > F_comp)
                {
                    Console.WriteLine("You are winner");
                }
                else if (a_2 == F_comp)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("You lose");
                }
            }
            if (b == 3)
            {
                if (a_3 > F_comp)
                {
                    Console.WriteLine("You are winner");
                }
                else if (a_3 == F_comp)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("You lose");
                }
            }
            if (b == 4)
            {
                if (a_4 > F_comp)
                {
                    Console.WriteLine("You are winner");
                }
                else if (a_4 == F_comp)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("You lose");
                }
            }
            if (b == 5)
            {
                if (a_5 > F_comp)
                {
                    Console.WriteLine("You are winner");
                }
                else if (a_5 == F_comp)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("You lose");
                }
            } 
            Console.WriteLine(" ");
            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("1 - yes" + "  " + "2 - no");
        } while(menu != 2);
    }
    
}
