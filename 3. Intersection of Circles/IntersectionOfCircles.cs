using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Intersection_of_Circles
{
    class IntersectionOfCircles
    {
        static void Main(string[] args)
        {
            CircleInput c1 = new CircleInput();
            CircleInput c2 = new CircleInput();
           bool trueFalse = Intersect(c1,c2);
        }
        static bool Intersect(CircleInput[] c1, CircleInput[] c2)
        {
            if(CalcDistance>(c1[2]+c2[2]))
            {

            }
            return trueFalse:
        }

        static double CalcDistance(CircleInput p1, CircleInput p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        static CircleInput ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            CircleInput circle = new CircleInput();
            circle.X = pointInfo[0];
            circle.Y = pointInfo[1];
            circle.R = pointInfo[2];
            return circle;
        }
    }
    class CircleInput
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
    }
}
