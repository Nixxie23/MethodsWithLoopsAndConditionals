using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    { public static int PrintRangePosNegThousand()
        {
          int i = 1000;
          for (i = 1000; i <= 1000 && i >= -1000; i--)
            {
                Console.WriteLine(i); 
            }
          return i;
          }
        public static int ThreeToNineHundred()
        {
            int x = 3;
            for (x = 3; x <= 999; x += 3)
            {
                Console.WriteLine(x);
            }


            return x;
        

        }
        public static int AreTheyEqual(int first, int second)
        {
            int a = first;
            int b = second;

            if (a == b)  
            {
                Console.WriteLine($"{a} equals {b}"); 
                    }
            else
            {
                Console.WriteLine($"{a} does not equal {b}");
            }
            return a; 
            return b;
                }
        public static int EvenOrOdd(int num)
        {
            if (num%2 == 0) 
            {
                Console.WriteLine($"{num} is even.");
                    }
            else
            { Console.WriteLine($"{num} is odd.");
            }
            return num;
        }
        public static int PosOrNeg(int num)
        {
            int c = num;   
            if (c > 0)
            {
                Console.WriteLine($"{c} is positive.");
            }
            else if (c<0) 
            {
                Console.WriteLine($"{c} is negative.");
            }
            else if (c == 0) 
            {
                Console.WriteLine($"{c} is not positive or negative.");
            }
            return c; 
        }
        public static int CanTheyVote(int voterAge)
        {                                                   
                   //originally i wanted console input for this one instead of getting the number from the parameter. Would that have been incorrect in the scope of this exercise? I tried to make it take either or but failed  
            if (voterAge >= 18)
            { 
                Console.WriteLine($"Do your civic duty my friend! {voterAge} is old enough to vote!");
            }
            else
            {
                Console.WriteLine($"You are not old enough! {18 - voterAge} years to go!");

            }
            return voterAge;
        }
        public static int TensRange(int num)
        {
            if (num <= 10 && num >= -10)
            {
                Console.WriteLine($"{num} is in the range of -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{num} is outside the range of -10 and 10.");

            }
            return num;
        }
        public static int MultiplicationTableTo12(int num)
        {
            Console.WriteLine($"1 * {num} = {1 * num}");
            Console.WriteLine($"2 * {num} = {2 * num}");
            Console.WriteLine($"3 * {num} = {3 * num}");
            Console.WriteLine($"4 * {num} = {4 * num}");
            Console.WriteLine($"5 * {num} = {5 * num}");
            Console.WriteLine($"6 * {num} = {6 * num}");
            Console.WriteLine($"7 * {num} = {7 * num}");
            Console.WriteLine($"8 * {num} = {8 * num}");
            Console.WriteLine($"9 * {num} = {9 * num}");
            Console.WriteLine($"10 * {num} = {10 * num}");
            Console.WriteLine($"11 * {num} = {11 * num}");
            Console.WriteLine($"12 * {num} = {12 * num}");
            return num;
        }
            static void Main(string[] args) 
        {
            PrintRangePosNegThousand();
            ThreeToNineHundred();
            AreTheyEqual(2, 3);
            AreTheyEqual(2, 2);
            EvenOrOdd(2);   
            EvenOrOdd(3);
            PosOrNeg(5);
            PosOrNeg(-6);
            PosOrNeg(0);
            CanTheyVote(23);
            CanTheyVote(7);
            TensRange(23);
            TensRange(10);
            TensRange(0);
            MultiplicationTableTo12(5);
            MultiplicationTableTo12(1);
        }


    }






}


