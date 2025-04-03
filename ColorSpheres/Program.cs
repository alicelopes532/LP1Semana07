using System;

namespace ColorSpheres
{
    class Color
    {
        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }
        public int Alpha { get; }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = Math.Clamp(red, 0, 255);
            Green = Math.Clamp(green, 0, 255);
            Blue = Math.Clamp(blue, 0, 255);
            Alpha = Math.Clamp(alpha, 0, 255);
        }

        public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

        public int GetGrey()
        {
            return (Red + Green + Blue) / 3;
        }
    }

    class Sphere
    {
        public Color Color { get; }
        public double Radius { get; private set; }
        private int timesThrown;

        public Sphere(Color color, double radius)
        {
            Color = color;
            Radius = radius;
            timesThrown = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return timesThrown;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Color redColor = new Color(255, 0, 0);
            Color blueColor = new Color(0, 0, 255, 200);
            Sphere sphere1 = new Sphere(redColor, 5.0);
            Sphere sphere2 = new Sphere(blueColor, 3.5);

            sphere1.Throw();
            sphere1.Throw();
            sphere2.Throw();
            sphere2.Pop();
            sphere2.Throw();

            Console.WriteLine($"Sphere1 - Color: ({sphere1.Color.Red}, {sphere1.Color.Green}, {sphere1.Color.Blue}, {sphere1.Color.Alpha}), Radius: {sphere1.Radius}, Times Thrown: {sphere1.GetTimesThrown()}");
            Console.WriteLine($"Sphere2 - Color: ({sphere2.Color.Red}, {sphere2.Color.Green}, {sphere2.Color.Blue}, {sphere2.Color.Alpha}), Radius: {sphere2.Radius}, Times Thrown: {sphere2.GetTimesThrown()}");
        }
    }
}
