using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNetCore.TestClasses
{
    public class Calculator
    {
        int result;

        public int Result { get => result; set => result = value; }

        public Calculator()
        {
            this.result = 0;
        }

        public Calculator(int value)
        {
            this.result = value;
        }

        public void Add(int value)
        {
            this.Result += value;
        }

        public void Multiply(int value)
        {
            this.Result *= value;
        }

        public void Divide(int value)
        {
            try
            {
                this.Result = this.Result / value;
            }
            catch (System.DivideByZeroException e)
            {
                throw new System.DivideByZeroException("divide by zero not allowed");
            }
        }
    }
}
