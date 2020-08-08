using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNetCore.TestClasses
{
    public class Calculator
    {
        float result;

        public float Result { get => result; set => result = value; }

        public Calculator()
        {
            this.result = 0;
        }

        public void Add(float value)
        {
            this.Result += value;
        }

        public void Multiply(float value)
        {
            this.Result *= value;
        }
    }
}
