using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace The_Life_Game
{
    class Meal
    {
        private Point location;
        private SolidBrush color;

        public Point Location { get => location; }
        public SolidBrush Color { get => color; }
        public static int Radius { get => 10; }
        public Meal()
        {
            var randLocation = new Random();
            location = new Point(randLocation.Next(5, 495), randLocation.Next(5, 495));

            color = new SolidBrush(System.Drawing.Color.LightGreen);
        }
    }
}
