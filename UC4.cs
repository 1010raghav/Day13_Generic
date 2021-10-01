using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_practice
{
    public class UC4<T> where T : IComparable
    {
        public T[] value;
       

        public UC4(T[] value)
        {
            this.value = value;
        }

        public T[]Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MacMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum Value is " + max);

        }



    }
}
