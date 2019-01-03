using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            float CurrentDistance = 10;
            float NextDistance = 0;
            float SumDistance = 10;
            int Percent = 10;
            int Days = 1;

            while(SumDistance<100)
            {
                NextDistance = CurrentDistance + (CurrentDistance * Percent / 100);
                SumDistance = SumDistance + NextDistance;
                Days += 2;
                CurrentDistance = NextDistance;
                Console.WriteLine($"Дистанция равняется {SumDistance}км на {Days} день");
            }
            Console.WriteLine($"\nДистанция превысит 100км за {Days} дней!");
            Console.ReadLine();
        }
    }
}
