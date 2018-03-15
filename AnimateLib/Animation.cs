using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimateLib
{
    public class Animation
    {
        public static string AnimateToString(int speed, string init) {
            var result = Animation.Animate(speed, init);
            return "{ " + string.Join(", " + Environment.NewLine, result) + " }";
        }
        public static IList<string> Animate(int speed, string init)
        {
            int chamberSize = init.Length;
            int time = 0;
            IList<Partical> particals = IntiParticals(init, speed);
            IList<string> chamberOverTime = new List<string>();

            while (true)
            {
                IList<int> particalPositions = CalculateParticalPositions(particals, time);
                chamberOverTime.Add(DrawChamber(particalPositions, chamberSize));
                if (!HasParticalsInChamber(particalPositions, chamberSize))
                {
                    break;
                }
                time = time + 1;
            }
            return chamberOverTime;
        }

        private static bool HasParticalsInChamber(IList<int> postions, int chamberSize)
        {
            foreach (int? particalPosition in postions)
            {
                if (0 <= particalPosition && particalPosition.Value < chamberSize)
                {
                    return true;
                }
            }
            return false;
        }

        private static IList<int> CalculateParticalPositions(IList<Partical> particals, int time)
        {
            IList<int> positions = new List<int>();
            foreach (Partical partical in particals)
            {
                positions.Add(partical.LocationAfter(time));
            }
            return positions;
        }

        private static string DrawChamber(IList<int> positions, int chamberSize)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < chamberSize; i++)
            {
                if (positions.Contains(i))
                {
                    builder.Append("X");
                }
                else
                {
                    builder.Append(".");
                }
            }
            return builder.ToString();
        }

        private static IList<Partical> IntiParticals(string init, int speed)
        {
            IList<Partical> particals = new List<Partical>();
            int chamberSize = init.Length;
            for (int i = 0; i < chamberSize; i++)
            {
                char current = init[i];
                if (current != '.')
                {
                    particals.Add(new Partical(current, i, speed));
                }
            }
            return particals;

        }
    }
}
