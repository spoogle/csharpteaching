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
        public static 
            int Fib(int n)
        {
            if (n < 3) return 1;

            int prev = 1;
            int current = 1;
            int counter = 2;

            while (counter < n)
            {
                ++counter;
                int next = prev + current;
                prev = current;
                current = next;
            }

            //for (int i = 2; i < n; ++i)
            //{
            //    int next = prev + current;
            //    prev = current;
            //    current = next;
            //}

            return current;
        }

        static void Main(string[] args)
        {
            // VARIABLES AND VALUES.
            Console.WriteLine("VARIABLES AND VALUES");

            // A comment starts with //.
            // You can store values in variables.
            // Each variable can only store values of a given type.
            // The type is given when the variable is declared.
            // 'int' means 'integer'
            int x;

            // Assign values to variables with '='.
            x = 1;
            
            // 1.
            // You can print the value.
            Console.WriteLine("1. x = " + x);
            
            // 2.
            // You can change the value.
            x = 2;
            Console.WriteLine("2. x = " + x);

            // 3.
            // 'float' means floating point, or real number.
            float y = 12.0f;
            Console.WriteLine("3. y = " + y);

            // 4.
            // There is another type for real numbers. The difference is only
            // the precision each can store. 
            // 'float' means floating point, or real number.
            // You can do calculations using normal arithmetic operations.
            double z = 1.3 + 2.9;
            Console.WriteLine("4. z = " + z);

            // 5.
            string s = "hello";
            Console.WriteLine("5. s is a string = " + s);

            bool b = false;
            Console.WriteLine("5. b is a bool = " + b);

            // These lines do not compile, because the right hand side of the = does not have the
            // same type as the variable on the left hand side:

            // x = 1.0;        // x is int, 1.0 is double
            // x = "hello";    // x is int, "hello" is string
            // s = 1;          // s is string, 1 is int.

            // FUNCTIONS
            Console.WriteLine("FUNCTIONS");

            // 6.
            int i = 10;
            int fib_i = Fib(i);
            int fib_11 = Fib(11);

            Console.WriteLine("6. fib(" + i + ") = " + fib_i);
            Console.WriteLine("6. fib(" + i + ") = " + fib_11);

            // STATEMENTS
            Console.WriteLine("STATEMENTS");
            
            // Code is organised as a sequence of _statements_.
            // Variable declaration and variable assignment are simple statements.
            // They must end with a ';'.

            // 8.
            // An 'if' statement is another kind of statement
            // The simplest kind of if statement has two parts:
            // A condition, in parentheses, e.g. (z > y)
            // A body, enclosed in { }
            if (y > z)
            {
                // The body can be any sequence of statements.
                // This part gets executed only if the condition part is true.
                Console.WriteLine("8. y is greater");
                Console.WriteLine("8. OK!");
            }

            // 9.
            if (z > y)
            {
                Console.WriteLine("9. z is greater");
            }

            // 10.
            // The body can even have another if statement.
            if (y > z)
            {
                Console.WriteLine("10. y is greater");
                if (y > z * 2)
                {
                    Console.WriteLine("10. y is much greater");
                }
            }

            // 11.
            // It can be quite hard to understand if you have lots of if statements
            // inside one another. It is better to write multiple if statements one after
            // the other.
            // The body can even have another if statement.
            if (y > z)
            {
                Console.WriteLine("11. y is greater");
            }
            if (y > z * 2)
            {
                Console.WriteLine("11. y is much greater");
            }

            // 12.
            // An if statement can also have an 'else' part, which is executed if the condition part
            // is false.
            if (y > z)
            {
                Console.WriteLine("12. y is greater");
            } else 
            {
                Console.WriteLine("12. z is greater");
            }

            // 13.
            // There is a little bug in the next lines. Can you find it?
            // An if statement can also have an 'else' part, which is executed if the condition part
            // is false.
            z = y;
            if (y > z)
            {
                Console.WriteLine("13. y is greater");
            }
            else
            {
                Console.WriteLine("13. z is greater");
            }
        }
    }
}
