using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        // Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        //For Example:
        public int Add(int num1, int num2, int num3)
        {
                return num1 + num2 + num3;
        }


        // Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method 


        // Step 4: 
        // Create a Subtract method that accepts 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }
        
        public int Multiply(int multiplicand, int multiplicor)
        {
            return multiplicand * multiplicor;
        }


        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        // Step 8: 
        // Create a Divide method that passes 2 integers
        public string Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                return "Error: cannot divide by zero.";
            
            return (dividend / divisor).ToString();
        }

        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}
