using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexasMoneyCalculator
{
    class MoneyAdder
    {
        public  void  AddingMoney()
        {
            string[] days = new string[] { "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Monday", "Tuesday" };
            string StartTime;
            string EndTime;
            double BreakTime;
            double DailyHours;
            double wage = 9.4;
            double PayDay = 0;
            double WeekPay = 0;
            Console.WriteLine("How many days per week do you work?");
            int z = Convert.ToInt32(Console.ReadLine());
                


            for (int i = 0; i <= z; i++)
            {
                Console.WriteLine("What time did you start on {0}", days[i]);
                StartTime = Console.ReadLine();
                TimeSpan spanStart = TimeSpan.Parse(StartTime);

                Console.WriteLine("what time did you end on {0}", days[i]);
                EndTime = Console.ReadLine();
                TimeSpan spanEnd = TimeSpan.Parse(EndTime);

                Console.WriteLine("How long was your break?");
                BreakTime = Convert.ToDouble(Console.ReadLine());

                if (spanEnd < spanStart)
                {

                    DailyHours = (spanStart - spanEnd).TotalHours - BreakTime;
                    Console.WriteLine("You worked a total of {0} hours.",DailyHours);
                    PayDay = DailyHours * wage;
                    Console.WriteLine("You made {0} on {1}.",PayDay,days[i]);
                }
                else if (spanStart < spanEnd)
                {
                    DailyHours = (spanEnd - spanStart).TotalHours - BreakTime;
                    Console.WriteLine("You worked a total of {0}.", DailyHours);
                    PayDay = DailyHours * wage;
                    Console.WriteLine("You made {0} on {1}.", PayDay, days[i]);
                }
                WeekPay += PayDay;
            }
            
            Console.WriteLine("Accumulating a total of {0} for days worked from {1} to {2}", WeekPay,days[0],days[z]);

            Console.ReadLine();
             
        }
    }
}
