using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliWhitmanLab9
{
    class MyMath
    {
        double result;
        double operand1 = 40;
        double operand2 = 2;
        

        public void Multiply(double operand1, double operand2)
        {
            result = operand1 * operand2;
            
        }
        public void Divide(double operand1, double operand2)
        {
            result = operand1 / operand2;
           
        }
        public void Subtract(double operand1, double operand2)
        {
            result = operand1 - operand2;
           
        }
        public void Add(double operand1, double operand2)
        {
            result = operand1 + operand2;
            

        }

        public void GetResult(double result)
        {
            Console.WriteLine("the anwser is... " + result);
        }


    }
}
