using System;
using System.Diagnostics;
using System.Linq;

namespace AdventOfCode.Day11
{
    public class HexGrid
    {
        Vector currentPosition = new Vector();

        public int CalculateSteps(string path)
        {
            var stepsTaken = path.Split(',').Select(dir => dir.Trim());
            var stepsEnumerator = stepsTaken.GetEnumerator();
            stepsEnumerator.MoveNext();
            currentPosition = new Vector(1, StepToDegree(stepsEnumerator.Current));
            while (stepsEnumerator.MoveNext())
            {
                Go(stepsEnumerator.Current);
            }

            return CountStepsToCurrentPosition();
        }

        private int CountStepsToCurrentPosition()
        {
            int steps = 0;
            if (Math.Abs(currentPosition.Length) < 0.0001) return 0;

            Vector pathFinder = null;
            while (pathFinder == null || !pathFinder.Equals(currentPosition))
            {
                if (pathFinder == null)
                {
                    var step = DegreeToStep(currentPosition.Degree);
                    pathFinder = new Vector(1, StepToDegree(step));
                    Debug.WriteLine(step);
                }
                else
                {
                    var step = DegreeToStep(CalcDegree(currentPosition, pathFinder));
                    pathFinder = pathFinder.Add(new Vector(1, StepToDegree(step)));
                    Debug.WriteLine(step);
                }
                steps++;
            }
            return steps;
        }

        private double CalcDegree(Vector currentPosition, Vector pathFinder)
        {
            double y1 = currentPosition.Length * Math.Sin(currentPosition.Degree * Math.PI / 180);
            double x1 = currentPosition.Length * Math.Cos(currentPosition.Degree * Math.PI / 180);
            double y2 = pathFinder.Length * Math.Sin(pathFinder.Degree * Math.PI / 180);
            double x2 = pathFinder.Length * Math.Cos(pathFinder.Degree * Math.PI / 180);

            var x3 = x1 - x2;
            var y3 = y1 - y2;

            return Math.Atan2(y3, x3) * 180 / Math.PI;
        }

        private string DegreeToStep(double inputDegree)
        {
            var degree = (360 + inputDegree) % 360;

            int stepAsInt = (int)Math.Floor(degree / (360 / 6));
            switch (stepAsInt)
            {
                case 0:
                    return "NE";
                case 1:
                    return "N";
                case 2:
                    return "NW";
                case 3:
                    return "SW";
                case 4:
                    return "S";
                case 5:
                    return "SE";
                default:
                    throw new ArgumentException("Degrees to large");
            }
        }

        private void Go(string step)
        {
            currentPosition = currentPosition.Add(new Vector(1, StepToDegree(step)));
        }

        private double StepToDegree(string step)
        {
            var mid = 360 / 6 / 2;
            switch (step.ToUpper())
            {
                case "NE":
                    return 360 / 6 * 0 + mid;
                case "N":
                    return 360 / 6 * 1 + mid;
                case "NW":
                    return 360 / 6 * 2 + mid;
                case "SW":
                    return 360 / 6 * 3 + mid;
                case "S":
                    return 360 / 6 * 4 + mid;
                case "SE":
                    return 360 / 6 * 5 + mid;
                default:
                    throw new ArgumentException("Wrong Direction given");
            }
        }
    }
}
