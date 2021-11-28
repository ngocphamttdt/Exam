using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static long carParkingRoof(List<long> cars, int k)
        {
            cars.Distinct();
            cars.Sort();
            long firstItem = cars.Min();
            long lastItem = cars.Max();

            long nextItemFromFirst = cars[k - 1];
            long nextItemFromLast = cars[cars.Count()- k];

            long fromFirstLength = nextItemFromFirst - firstItem + 1;
            long fromLastLength = lastItem - nextItemFromLast + 1;
            return fromFirstLength < fromLastLength ? fromFirstLength : fromLastLength;

        }
        static void Main(string[] args)
        {
            var test = carParkingRoof(new List<long> { 2, 6, 7, 12 }, 3);
            Console.WriteLine("data", test);
        }
    }
}
