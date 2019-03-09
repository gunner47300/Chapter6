using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
                Excercise1();
                Excercise2();
                Excercise3();
                Excercise4();
                Excercise5();
                Excercise6();
                Excercise7a();
                Excercise8();
                Excercise9();
                Excercise10();
                Excercise11();
                Excercise12();
                Excercise13();
                Excercise14();
                Excercise15();
                Excercise16();
                Excercise17();
                Excercise18();
        }
                     
        static void Excercise1()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++) Console.WriteLine(i);

        }

        static void Excercise2()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (!(i % 21 == 0)) Console.WriteLine(i);
            }
        }

        static void Excercise3()
        {
            int input;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input > max) max = input;
                if (input < min) min = input;
            }
            Console.WriteLine("Max: {0}\tMin:{1}", max, min);
        }

        static void Excercise4()
        {
            int a = 1;
            for (int i = 0; i < 4; i++)
            {                
                for (int j = 0; j < 13; j++)
                {
                    Console.Write(a + ".\t" + GetColour(i) + "\t");
                    Console.WriteLine(GetCard(j));
                    a++;
                }
            }
        }

        static void Excercise5()
        {
            int input = int.Parse(Console.ReadLine());
            if (input <= 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                BigInteger sum = 1;
                BigInteger[] fibbonacciSequence = new BigInteger[3];
                fibbonacciSequence[0] = 0;
                fibbonacciSequence[1] = 1;

                for (int i = 2; i < input; i++)
                {
                    fibbonacciSequence[2] = fibbonacciSequence[0] + fibbonacciSequence[1];
                    fibbonacciSequence[0] = fibbonacciSequence[1];
                    fibbonacciSequence[1] = fibbonacciSequence[2];
                    sum += fibbonacciSequence[2];
                }
                Console.WriteLine(sum);
            }
        }

        static void Excercise6()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long a = 1;
            long b = 1;

            for(int i = 1; i <= n; i++)
            {
                a *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                b *= i;
            }
            Console.WriteLine(a + " / " + b + " = " + (a / b));

        }

        static void Excercise7()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long a = 1;
            long b = 1;
            long c = 1;

            for (int i = 1; i <= n; i++)
            {
                a *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                b *= i;
            }

            for (int i = 1; i <= n-k; i++)
            {
                c *= i;
            }
            Console.WriteLine("{0} * {1} / {2} = {3} ",a, b, c, (a * b / c));
        }

        static void Excercise7a()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long a = 1;
            long b = 1;
            long c = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i <= n - k)
                {
                    b = a = c *= i; //  n-k ->  c
                }
                else if (i <= k)
                {
                    b = a *= i;     //  k   ->  a
                }
                else
                {
                    b *= i;         //  n   ->  b
                }
            }
            Console.WriteLine("{0} * {1} / {2} = {3} ", b, a, c, (b * a / c));
        }

        static void Excercise8()
        {
            int n = int.Parse(Console.ReadLine());
            long a = 1;
            long b = 1;
            long c = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                if (i <= n)
                {
                    c = b = a *= i; //n!
                }
                else if(i<=n+1)
                {
                    c = b *= i; //(n+1)!
                }
                else
                {
                    c *= i; //(2n)!
                }
            }
            Console.WriteLine(c / (b * a));
        }

        static void Excercise9()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double power = 1;
            long factor = 1;
            double answer = 1;

            for (int i = 1; i <= n; i++)
            {
                factor *= i;
                power *= x;
                answer += (factor / power);

            }
            Console.WriteLine(answer);
        }

        static void Excercise10()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n,n];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array[i, j] = i + j + 1;
                    Console.Write(array[i, j]);
                }
                Console.Write("\n");
            }
        }

        static void Excercise11()
        {
            int n = int.Parse(Console.ReadLine());
            long factorial = 1;
            int answer = 0;

            for (int i = 1; i < n + 1; i++)
            {
                factorial *= i;
            }

            n = factorial.ToString().Length;

            while(factorial % 10 == 0)
            {
                answer++;
                factorial /= 10;
            }



            Console.WriteLine(answer);

        }

        static void Excercise12()
        {
            int n = int.Parse(Console.ReadLine());
            string answer="";
            while (n != 0)
            {
                if (n % 2 == 0) answer += "0";
                else answer += "1";
                n /= 2;
            }

            for(int i = answer.Length; i > 0; i--)
            {
                Console.Write(answer[i-1]);
            }
            Console.WriteLine();
        }

        static void Excercise13()
        {
            int n = int.Parse(Console.ReadLine());
            int condition = n.ToString().Length;
            double answer = 0;

            for(int i = 0; i < condition; i++)
            {
                answer += n % 10 * Math.Pow(2, i);
                n /= 10;
            }

            Console.WriteLine(answer);
        }

        static void Excercise14()
        {
            int n = int.Parse(Console.ReadLine());
            string answer = "";
            while (n != 0)
            {
                answer += GetHexidecimal(n%16);
                n /= 16;
            }

            for (int i = answer.Length; i > 0; i--)
            {
                Console.Write(answer[i - 1]);
            }
            Console.WriteLine();
        }

        static void Excercise15()
        {
            string n = Console.ReadLine();
            double answer = 0;

            for(int i = 0; i < n.Length; i++)
            {
                answer += GetDecimal(n[i]) * Math.Pow(16, n.Length-i-1);
            }
            Console.WriteLine(answer);

        }

        static void Excercise16()
        {
            Random random = new Random();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] answer = new int[n];

            for(int i = 0; i < n; i++)
            {
                answer[i] = i + 1;                
            }

            for(int i = 0; i < n; i++)
            {

                int[] randomNumber = new int[] { random.Next(n), random.Next(n) };
                int buffor = answer[randomNumber[0]];
                answer[randomNumber[0]] = answer[randomNumber[1]];
                answer[randomNumber[1]] = buffor;

            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(answer[i]);
            }
            Console.WriteLine();
        }

        static void Excercise17()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int ab = a * b;
            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            Console.WriteLine("GCD: " + a);
            Console.WriteLine("LCM: " + (ab/a));
        }

        static void Excercise18()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n,n];
            int size = n;            
            int i = 1;
            int l = 0;
            int x = 0;
            int y = 0;

            if (n % 2 != 0)
            {
                x = y = n / 2;
                array[x, y] = size * size;
                x = y = 0;
            }


            while (i<size*size)
            {
                while (x < n - 1)
                {
                    array[y, x++] = i++;
                }


                while (y < n - 1)
                {
                    array[y++, x] = i++;
                }


                while (x > l)
                {
                    array[y, x--] = i++;
                }

                while (y > l)
                {
                    array[y--, x] = i++;
                }

                y++;
                x++;
                n--;
                l++; 
            }

            for (int j = 0; j < size; j++)
            {
                for(int k=0; k<size; k++)
                {
                    Console.Write("{0}\t",array[j, k]);
                }
                Console.WriteLine();
            }

        }

        static string GetColour(int a)
        {
            switch (a)
            {
                case 0:
                    return "club";
                case 1:
                    return "diamond";
                case 2:
                    return "heart";
                case 3:
                    return "spades";
                default:
                    return "unknown";
            }
        }

        static string GetCard(int a)
        {
            switch (a)
            {
                case 0:
                    return "2";
                case 1:
                    return "3";
                case 2:
                    return "4";
                case 3:
                    return "5";
                case 4:
                    return "6";
                case 5:
                    return "7";
                case 6:
                    return "8";
                case 7:
                    return "9";
                case 8:
                    return "10";
                case 9:
                    return "J";
                case 10:
                    return "Q";
                case 11:
                    return "K";
                case 12:
                    return "A";
                default:
                    return "unknown";
            }
        }

        static string GetHexidecimal(int a)
        {
            switch (a)
            {
                case 0:
                    return "0";
                case 1:
                    return "1";
                case 2:
                    return "2";
                case 3:
                    return "3";
                case 4:
                    return "4";
                case 5:
                    return "5";
                case 6:
                    return "6";
                case 7:
                    return "7";
                case 8:
                    return "8";
                case 9:
                    return "9";
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    return "unknown";
            }
        }

        static int GetDecimal(char a)
        {
            switch (a)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'a':
                    return 10;
                case 'A':
                    return 10;
                case 'b':
                    return 11;
                case 'B':
                    return 11;
                case 'c':
                    return 12;
                case 'C':
                    return 12;
                case 'd':
                    return 13;
                case 'D':
                    return 13;
                case 'e':
                    return 14;
                case 'E':
                    return 14;
                case 'f':
                    return 15;
                case 'F':
                    return 15;
                default:
                    return 0;
            }
        }
    }
}

/*

1.    Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.

2.    Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.

3.    Write a program that reads from the console a series of integers and prints the smallest and largest of them.

4.    Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).

5.    Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

6.    Write a program that calculates N!/K! for given N and K (1<K<N).

7.    Write a program that calculates N!*K!/(N-K)! for given N and K (1<K<N).

8.    In combinatorics, the Catalan numbers are calculated by the following formula: clip_image013[6], for n ≥ 0. Write a program that calculates the nth Catalan number by given n.

9.    Write a program that for a given integers n and x, calculates the sum: clip_image015[6]

10.   Write a program that reads from the console a positive integer number N (N < 20) and prints a matrix of numbers as on the figures below:

    1   2   3   4
    2   3   4   5
    3   4   5   6
    4   5   6   7

11.   Write a program that calculates with how many zeroes the factorial of a given number ends. Examples:

N = 10 -> N! = 3628800 -> 2

      N = 20 -> N! = 2432902008176640000 -> 4

12.   Write a program that converts a given number from decimal to binary notation (numeral system).

13.   Write a program that converts a given number from binary to decimal notation.

14.   Write a program that converts a given number from decimal to hexadecimal notation.

15.   Write a program that converts a given number from hexadecimal to decimal notation.

16. Write a program that by a given integer N prints the numbers from 1 to N in random order.

17.   Write a program that given two numbers finds their greatest common divisor (GCD) and their least common multiple (LCM). You may use the formula LCM(a, b) = |a*b| / GCD(a, b).

18.   * Write a program that for a given number n, outputs a matrix in the form of a spiral:
*/
