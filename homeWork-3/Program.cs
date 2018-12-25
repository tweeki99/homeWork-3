using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine();

            int gaps = 0;
            while (true)
            {
                string symbol = Console.ReadLine();
                if (symbol == ".") break;
                else if (symbol == " ") gaps++;
            }
            Console.WriteLine();
            Console.WriteLine(gaps);



            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine();

            Console.WriteLine("Введите номер билета");
            string ticketNumber = Console.ReadLine();


            bool isOnlyNumbers = true;
            foreach (char symbol in ticketNumber)
            {
                if (symbol < '0' || symbol > '9')
                {
                    isOnlyNumbers = false;
                }
            }

            if (isOnlyNumbers && ticketNumber.Length == 6)
            {
                int charToInt = -48;
                int firstSequence = 0, secondSequence = 0;

                firstSequence += ticketNumber[0] + charToInt + ticketNumber[1] + charToInt + ticketNumber[2] + charToInt;
                secondSequence += ticketNumber[3] + charToInt + ticketNumber[4] + charToInt + ticketNumber[5] + charToInt;

                if (firstSequence == secondSequence) Console.WriteLine("Счастливый билет");
                else Console.WriteLine("Обычный билет");
            }
            else Console.WriteLine("Некорректные данные");



            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Console.WriteLine();

            Console.WriteLine("Введите строку");
            StringBuilder stringBuilder = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < stringBuilder.Length; i++)
            {

                if (char.IsLetter(stringBuilder[i]))
                {
                    if (char.IsUpper(stringBuilder[i]))
                    {
                        stringBuilder[i] += (char)32;
                    }
                    else stringBuilder[i] -= (char)32;

                }
            }
            Console.WriteLine(stringBuilder);



            Console.WriteLine();
            Console.WriteLine("Задание 4");
            Console.WriteLine();

            Console.WriteLine("Введите два числа");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                int temp = secondNumber;
                secondNumber = firstNumber;
                firstNumber = temp;
            }
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine("Задание 5");
            Console.WriteLine();
           
            Console.WriteLine("Введите числo");
            StringBuilder number = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < number.Length / 2; i++)
            {
                char temp = number[i];
                number[i] = number[number.Length - 1 - i];
                number[number.Length - 1 - i] = temp;
            }
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
