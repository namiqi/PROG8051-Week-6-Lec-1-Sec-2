using System;


namespace CSharpTutorials
{
    class Program
    {

        // How to create a method
        // f(x) = 5
        static void welcome()
        {
            // goal of the function

            Console.WriteLine("Hello and Welcome");
            Console.WriteLine("How are you");
            Console.WriteLine("Help yourself");
        }


        // create a funciton with paramaters(/inputs)
        static void welcomeBack(string name)
        {
            // goal of the function

            Console.WriteLine($"welcome back, {name}");
        }

        static void welcomeBack(string name="John", int age=24)
        {
            // goal of the function

            Console.WriteLine($"welcome back, {name} and I heard you are {age} years old, is that correct?");
        }


        
        static void sub(double a, double b)
        {
            Console.WriteLine(a - b);

        }
        static void mul(double a, double b)
        {
            Console.WriteLine(a * b);
        }
        static void div(double a, double b)
        {
            Console.WriteLine(a / b);
        }



        static double add(double a, double b)
        {
            return a + b;
        }

        static double add(double a, double b, double c)
        {
            return a + b+c;
        }
        static string add(string a, string b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(add(4, 6));
            Console.WriteLine(add(4, 6,65));
            Console.WriteLine(add("Hi ", " Hello"));



            Console.WriteLine("-------------");












            Console.WriteLine("Enter 1st number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please make your choice: \n  1 for + \n 2 for - \n 3 for * \n 4 for /");

            Console.WriteLine("Enter the number between 1 and 4: ");
            int op = Convert.ToInt32(Console.ReadLine());



            switch (op)
            {
                case 1:
                    double answer = add(n1, n2);
                    Console.WriteLine(answer); 
                    break;
                case 2:
                    sub(n1, n2);
                    break;
                case 3:
                    mul(n1, n2);
                    break;
                case 4:
                    div(n1, n2);
                    break;
                default:
                    Console.WriteLine("Bad input");
                    break;

            }

            Console.WriteLine("-------------");


           // switch case

           int day = 4;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Bad input");
                    break;

            }














            welcomeBack("John");
            welcomeBack("John", 23);
            welcomeBack();

            // how to call/use a function
            welcome();
            welcome();
            welcome();

            int a = 5;
            int b = 35;

            welcome();
            welcome();






        }
    }
}