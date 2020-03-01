using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace The_Life_Game
{
    class Cell
    {
        private int age;
        private Sex sex;
        private Point location;

        private void CheckBorderOfField()
        {
            var borderUp = 0;
            var borderDown = 500;
            var borderLeft = 0;
            var borderRight = 500;
            var border = 5;

            if (location.X >= borderRight) location.X = borderLeft + border;
            else if (location.X <= borderLeft) location.X = borderRight - border;

            if (location.Y >= borderDown) location.Y = borderUp + border;
            else if (location.Y <= borderUp) location.Y = borderDown - border;
        }

        public int Age { get => age; }
        public Sex Sex { get => sex; }
        public SolidBrush Color { get ; }
        public Point Location { get => location; }
        static public int Radius { get => 10; }

        public Cell(Sex sex, Point location, int age = 20)
        {
            this.sex = sex;
            this.location = location;
            this.age = age;

            Color = Sex switch
            {
                Sex.Male => new SolidBrush(System.Drawing.Color.Blue),
                Sex.Female => new SolidBrush(System.Drawing.Color.Pink),
                _ => new SolidBrush(System.Drawing.Color.Black),
            };

        }

        public void Run()
        {
            var direction = (Direction)(new Random().Next(1, 4));
            var step = 5;

            switch (direction)
            {
                case Direction.Up:
                    CheckBorderOfField();
                    location.Y += step;
                    break;
                case Direction.Down:
                    CheckBorderOfField();
                    location.Y -= step;
                    break;
                case Direction.Left:
                    CheckBorderOfField();
                    location.X += step;
                    break;
                case Direction.Right:
                    CheckBorderOfField();
                    location.X -= step;
                    break;
            }
        }
    }
}
