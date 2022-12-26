using System;

internal class Program
{


    private static void Main(string[] args){

        int balls = 0;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Cистема программного обеспечения, что управляет работой всех структурных узлов компьютера, называется:");
        Console.WriteLine("1 - автоматизированная \n\r 2 - операционная \n\r  3 - интеллектуальная");
        int answer = Convert.ToInt32(Console.ReadLine());

        if(answer == 1 || answer == 3) {
            Console.WriteLine("________________________");
            Console.WriteLine("Ответ не правильный");
            Console.WriteLine("________________________");
        }

        else
        {
            Console.WriteLine("________________________");
            Console.WriteLine("Ответ правильный");
            Console.WriteLine("________________________");
            balls = 2;
          
        }
        Console.WriteLine("Cовокупность данных, что размещены на диске и имеют общее имя и назначение – это: ");
        Console.WriteLine("1 - файл \n\r 2 - процессор \r\n 3 - сектор");
         answer = Convert.ToInt32(Console.ReadLine());

        if (answer == 2 || answer == 3)
        {
            Console.WriteLine("________________________");
            Console.WriteLine("Ответ не правильный");
            Console.WriteLine("________________________");
        }

        else
        {
            Console.WriteLine("________________________");
            Console.WriteLine("Ответ правильный");
            Console.WriteLine("________________________");
            balls += 2;

        }

        Console.WriteLine("Для изображения в блок-схеме алгоритма условия разветвления используются графические элементы: ");
        Console.WriteLine("1 - квадрат \r\n 2 - круг \r\n 3 - ромб ");
        answer = Convert.ToInt32(Console.ReadLine());

        if (answer == 1 || answer == 2)
        {
            Console.WriteLine("________________________");
            Console.WriteLine("Ответ не правильный");
            Console.WriteLine("________________________");
        }
        else
        {
            Console.WriteLine("________________________");
            Console.WriteLine("Ответ правильный");
            Console.WriteLine("________________________");
            balls += 1;

        }

        if(balls == 5)
        {
            Console.WriteLine($"Вы набрали {balls} баллов.");
            Console.WriteLine("Ваша оценка 5");
        }
        else if(balls == 4) 
        {
            Console.WriteLine($"Вы набрали {balls} баллов.");
            Console.WriteLine("Ваша оценка 4");
        }
        else if(balls == 3)
        {

            Console.WriteLine($"Вы набрали {balls} баллов.");
            Console.WriteLine("Ваша оценка 3");
        }
        else if(balls == 2)
        {

            Console.WriteLine($"Вы набрали {balls} баллов.");
            Console.WriteLine("Ваша оценка 2");
        }
        else if(balls == 0)
        {
            Console.WriteLine("Вы ответили неправильно на все вопросы \r\n ППопробуйте ещё раз");
        }

    }
}
