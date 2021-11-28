using System;
using System.Collections.Generic;
using System.Linq;

namespace Bulb
{
    class Program
    {
        public static int NumTimesAllBlue(int[] lights)
        {
            List<int> moments = new List<int>();
            int numOfLight = lights.Count();
            //create array line lights   //var distanceToFirst = turnOnLight - 1;
            int[] lineLight = new int[numOfLight];
            foreach (int turnOnLight in lights)
            {
                lineLight[turnOnLight - 1] = 1;
                bool rangeAllTurnOn = true;
                for (int i = 0; i < turnOnLight; i++)
                {
                    if ( lineLight[i] == 0)
                    {
                        rangeAllTurnOn = false;
                        break;
                    }  
                }
                if (rangeAllTurnOn) moments.Add(turnOnLight);
            }
            return moments.Count();
        }
        static void Main(string[] args)
        {
            int[] lights = { 2, 1, 3, 5, 4 }; //[4,1,2,3]
            int result = NumTimesAllBlue(lights);
            Console.WriteLine("Hello World!", result);
        }
    }
}
