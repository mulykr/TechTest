using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalTest.TaskTwo
{
    public class TextInput
    {
        protected string ResultString;

        public TextInput()
        {
            ResultString = string.Empty;
        }

        public string GetValue()
        {
            return ResultString;
        }

        public virtual void Add(char value)
        {
            ResultString += value;
        }
    }
}
