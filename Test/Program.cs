using System;

namespace Example
{
    public class FibClass
    {
        public int FibMeth(int n)
        {
            if (n < 3) return 1;

            int prev = 1;
            int current = 1;
            for (int i = 2; i < n; ++i)
            {
                int next = prev + current;
                prev = current;
                current = next;
            }
            return current;
        }
    }

    class Program
    {
        public static int Fib(int n)
        {
            if (n < 3) return 1;

            int prev = 1;
            int current = 1;
            for (int i = 2; i < n; ++i)
            {
                int next = prev + current;
                prev = current;
                current = next;
            }
            return current;
        }

        static void Main(string[] args)
        {
            // VARIABLES AND VALUES.

            // A comment starts with //.
            // You can store values in variables.
            // Each variable can only store values of a given type.
            // The type is given when the variable is declared.
            // 'int' means 'integer'
            int x;

            // Assign values to variables with '='.
            x = 1;

            // You can print the value.
            Console.WriteLine("x = " + x);

            // You can change the value.
            x = 2;
            Console.WriteLine("x = " + x);

            // 'float' means floating point, or real number.
            float y = 12.0f;
            Console.WriteLine("y = " + y);

            // There is another type for real numbers. The difference is only
            // the precision each can store. 
            // 'float' means floating point, or real number.
            // You can do calculations using normal arithmetic operations.
            double z = 1.3 + 2.9;
            Console.WriteLine("z = " + z);

            // FUNCTIONS
            int i = 10;
            int fib_i = Fib(i);
            Console.WriteLine("fib(" + i + ") = " + fib_i);

            // STATEMENTS
            // Code is organised as a sequence of _statements_.
            // Variable declaration and variable assignment are simple statements.
            // They must end with a ';'.

            // An 'if' statement is another kind of statement
            // The simplest kind of if statement has two parts:
            // A condition, in parentheses, e.g. (z > y)
            // A body, enclosed in { }
            if (y > z)
            {
                // The body can be any sequence of statements.
                // This part gets executed only if the condition part is true.
                Console.WriteLine("y is greater");
                Console.WriteLine("OK!");
            }

            if (z > y)
            {
                Console.WriteLine("z is greater");
            }


            // The body can even have another if statement.
            if (y > z)
            {
                Console.WriteLine("y is greater");
                if (y > z * 2)
                {
                    Console.WriteLine("y is much greater");
                }
            }

            // It can be quite hard to understand if you have lots of if statements
            // inside one another. It is better to write multiple if statements one after
            // the other.
            // The body can even have another if statement.
            if (y > z)
            {
                Console.WriteLine("y is greater");
            }
            if (y > z * 2)
            {
                Console.WriteLine("y is much greater");
            }

            // An if statement can also have an 'else' part, which is executed if the condition part
            // is false.
            if (y > z)
            {
                Console.WriteLine("y is greater");
            } else 
            {
                Console.WriteLine("z is greater");
            }

            // There is a little bug in the next lines. Can you find it?
            // An if statement can also have an 'else' part, which is executed if the condition part
            // is false.
            z = y;
            if (y > z)
            {
                Console.WriteLine("y is greater");
            }
            else
            {
                Console.WriteLine("z is greater");
            }
        }
    }
}
