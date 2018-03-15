using AnimateLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimate
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string init = "..R....";
            int speed = 2;
            var result = Animation.AnimateToString(speed, init);
            Console.WriteLine(result);
            Console.WriteLine(Environment.NewLine);

            //2
            init = "RR..LRL";
            speed = 3;
            result = Animation.AnimateToString(speed, init);
            Console.WriteLine(result);

            Console.WriteLine(Environment.NewLine);

            //3
            init = "LRLR.LRLR"; speed = 2;
            result = Animation.AnimateToString(speed, init);
            Console.WriteLine(result);

            Console.WriteLine(Environment.NewLine);

            //4
            init = "RLRLRLRLRL"; speed = 10;
            result = Animation.AnimateToString(speed, init);
            Console.WriteLine(result);

            Console.WriteLine(Environment.NewLine);

            //5 
            init = "..."; speed = 1;
            result = Animation.AnimateToString(speed, init);
            Console.WriteLine(result);

            Console.WriteLine(Environment.NewLine);

            //6
            init = "LRRL.LR.LRR.R.LRRL."; speed = 1;
            result = Animation.AnimateToString(speed, init);
            Console.WriteLine(result);
        }
    }
    
}
