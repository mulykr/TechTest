using System;

namespace TechnicalTest.TaskTwo
{
    public class NumberInput : TextInput
    {
        public override void Add(char value)
        {
            if (!char.IsDigit(value))
            {
                throw new ArgumentException($"Invalid argument value {value} was given");
            }

            ResultString += value;
        }
    }
}
