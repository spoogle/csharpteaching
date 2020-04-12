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
            }
            else
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

            // LOOPS
            // Loops help to avoid repeating the same statements over and over again.

            // 14. 

            x = 0;
            Console.WriteLine("14. x = " + x);
            x = x + 1;
            Console.WriteLine("14. x = " + x);
            x = x + 1;
            Console.WriteLine("14. x = " + x);
            x = x + 1;
            Console.WriteLine("14. x = " + x);

            // The simplest kind of loop - but not the most common - is the 'while' loop.

            // Like an 'if' statement, it has a condition and a body. The body is executed
            // as long as the condition is true. Usually, the condition refers to a variable whose value
            // is changed by something in the body, and eventually the condition will be false and the
            // loop will stop.

            // This is a bit repetitive. We can use a loop instead.
            x = 0;
            while (x < 10)
            {
                Console.WriteLine("14. In loop x = " + x);
                x = x + 1;
            }
            Console.WriteLine("14. After the loop, x = " + x);

            // 15. Shortcuts.
            // By the way, there are a few shortcuts for adding to a variable:
            x = 0;
            Console.WriteLine("15. x = " + x);
            x++;
            Console.WriteLine("15. x = " + x);

            Console.WriteLine("15. x = " + x);
            ++x;
            Console.WriteLine("15. x = " + x);

            Console.WriteLine("15. x = " + x);
            x+=1;
            Console.WriteLine("15. x = " + x);

            // 16.
            // The commonest form of loop is the 'if' statement.
            // Usually, this does three things: declares loop counter variable, with
            // a given value at the start, changes the value of the loop counter, 
            // and checks the value of the loop counter.
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine("16. i = " + i);
            }

            // 17.
            Console.WriteLine("FUNCTIONS");
            // FUNCTIONS
            // Functions are another way of avoiding repeating code.
            // We already used a function:
            Console.WriteLine("17. This was a function call.");

            // The string "17. This was a function call" was passed to some other
            // code, which did something with it (printed it out).
            // If you called it with a different string in the parentheses then
            // you would see a different result.
            Console.WriteLine("17. So was this.");

            // There are two parts to a function:

            // The function call: func_name(value1, value2, ...)
            // This has the name of the function you want to execute, and values
            // for the parameters of the function.
            // In the case above, func_name was Console.WriteLine, and value1 was "17. So was this.".
            // There was no value2 (different functions have numbers of parameters - even 0!)

            // The function declaration: 
            // return_type func_name(type1 parm1, type2 parm2,...)
            // {
            //    body
            // }
            // This has:
            // return_type - when it is called, the function will return a value of this type
            // the function name - this is how you will refer to the function when you
            // call it
            // A list of parameters, with their types - when you call the function,
            // you must specify values for these parameters.
            // A body - the statement or statements which are executed when the function is called.

            int double_me(int a)
            {
                return a * 2;
            }

            int a = 7;
            Console.WriteLine("17. a = " + a + ", double_me(" + a + ") = " + double_me(a));

            // The function can be quite complex:
            // Returns the nth fibonnaci number.
            int fib(int n)
            {
                // If the body of a loop is a single statement, you can omit the { }.
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

            int fib_10 = fib(10);
            Console.WriteLine("17. fib(" + 10 + ") = " + fib_10);

            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine("17. fib(" + i + ") = " + fib(i));
            }
        }
    }
}
