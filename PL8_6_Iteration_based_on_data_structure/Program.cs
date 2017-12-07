using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PL8_6_Iteration_based_on_data_structure
{
    class Program
    {
        static void Main()
        {
            DaysOfTheWeek days = new DaysOfTheWeek();

            foreach (var day in days)
            {
                Console.Write(day + " ");
            }

            Console.ReadKey();
        }

        public class DaysOfTheWeek : IEnumerable
        {
            private string[] days = { "Sun", "Mon", "Tue", "Web", "Thu", "Fri", "Sat" };

            public IEnumerator GetEnumerator()
            {
                for (int index = 0; index < days.Length; index++)
                {
                    yield return days[index];
                }
            }
        }
    }
}
