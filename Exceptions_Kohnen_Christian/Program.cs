using System;
using System.Runtime.InteropServices;

namespace Exceptions_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 65.4f;                                              //assigns the value to myFloat as 65.4
            float myOtherFloat = 0.0f;                                          //assigns the vlaue to myOtherFloat to 0
            float result = 0f;                                                  //assigns the value to result as 0

            Random rand = new Random();                                         //creates a random object
            int myInt = rand.Next(2,30);                                        //sets the value of myInt to between 2 and 30

            try
            {
                result = Divide(myFloat, myOtherFloat);                         //tries to divide the floats
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);                                   //outputs the exception message if it occurs
                Console.WriteLine("Please enter a number other than 0");        //prints a messagem kindly
                try
                {
                    myOtherFloat = (float)Convert.ToDouble(Console.ReadLine()); //turns the float to a double
                    result = Divide(myFloat, myOtherFloat);                     //tries to divide it again
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);                              //sends another exception mkessage if it happens
                }
            }
            finally
            {
                Console.WriteLine("Completed Calculations. Result:" +  result); //outputs the result
            }

            try
            {
                CheckAge(myInt);                                                //checks the age int
            }
            catch
            {
                Console.WriteLine($"You are {myInt}, you are not old enough!"); //if the age isn't met, it prints a message
            }
        }
        static float Divide(float x, float y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }
        /// <summary>
        /// creates the divide method with float x and float y
        /// if y is zero, it initializes a new class. other than that, it divides the x by y
        /// </summary>
        /// <param name="age"></param>
        /// <exception cref="ArgumentException"></exception>
        static void CheckAge(int age)
        {
            if(age >= 17)
            {
                Console.WriteLine($"Age: {age}");
            }
            else
            {
                throw new ArgumentException();
            }

        }
        /// <summary>
        /// creates the CheckAge method with int age
        /// if the age int is bigger or equal to 17, it prints the age. else, it throws a new instance
        /// </summary>
    }
}