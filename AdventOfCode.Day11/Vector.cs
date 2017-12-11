using System;

namespace AdventOfCode.Day11
{
    public class Vector
    {
        public Vector(double length = 0, double degree = 0)
        {
            Length = length;
            Degree = degree;
        }

        public double Degree { get; set; }
        public double Length { get; set; }

        public Vector Add(Vector anotherVector)
        {
            var phi1 = Degree * Math.PI / 180;
            var phi2 = anotherVector.Degree * Math.PI / 180;

            return new Vector
            {
                Degree = (360 + (phi1 + Math.Atan2(anotherVector.Length * Math.Sin(phi2 - phi1), Length + anotherVector.Length * Math.Cos(phi2 - phi1))) * 180 / Math.PI) % 360,
                Length = Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(anotherVector.Length, 2) + 2 * Length * anotherVector.Length * Math.Cos(phi2 - phi1))
            };
        }

        public override bool Equals(object obj)
        {
            Vector otherVector = obj as Vector;
            return EpsCompare(otherVector.Length, Length) && EpsCompare(otherVector.Degree, Degree);
        }

        private bool EpsCompare(double value1, double value2)
        {
            return Math.Abs(value1 - value2) <= Math.Abs(value1 * .00001);
        }
    }
}
