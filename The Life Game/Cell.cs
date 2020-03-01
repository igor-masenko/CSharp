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
            if (location.X >= 500) location.X = 5;
            else if (location.X <= 0) location.X = 495;

            if (location.Y >= 500) location.Y = 5;
            else if (location.Y <= 0) location.Y = 495;
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
            Direction direction = (Direction)(new Random().Next(1, 4));

            switch (direction)
            {
                case Direction.Up:
                    CheckBorderOfField();
                    location.Y += 5;
                    break;
                case Direction.Down:
                    CheckBorderOfField();
                    location.Y -= 5;
                    break;
                case Direction.Left:
                    CheckBorderOfField();
                    location.X += 5;
                    break;
                case Direction.Right:
                    CheckBorderOfField();
                    location.X -= 5;
                    break;
            }
        }
    }
}
