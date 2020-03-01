using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Life_Game
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        // в начале всего были Адам и Ева
        private List<Cell> population = new List<Cell>()
        { 
            new Cell(Sex.Male, new Point(200, 200)), 
            new Cell(Sex.Female, new Point(150, 200)) 
        };

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox.CreateGraphics();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pictureBox.Refresh();
            var kids = new List<Cell>(); // здесь будут дети, появшиеся от пересечения 
            
            foreach (var cell in population)
            {
                cell.Run();
                graphics.FillEllipse(cell.Color, cell.Location.X, cell.Location.Y, Cell.Radius, Cell.Radius);
            }

            var randSex = new Random();
            var randLocation = new Random();
            // когда все сделали ход, ищем любовничков
            for (var i = 0; i < population.Count; i++)
            {
                for (var j = i; j < population.Count; j++)
                {
                    if (LetsMakeOut(population[i], population[j]))
                    {
                        // новый гендерный пол
                        var newSex = (Sex)randSex.Next(0, 2);

                        // новая локация, так как делать клетку на месте рождения - самоубийство
                        // они начинают плодиться в геометрической прогрессии. Разом.
                        // пускай рождаются в радиусе 100 пикселей
                        var bornRadius = 50;
                        var bornX = population[j].Location.X + randLocation.Next(-bornRadius, bornRadius);
                        var bornY = population[j].Location.Y + randLocation.Next(-bornRadius, bornRadius);
                        var newLocation = new Point(bornX, bornY);

                        kids.Add(new Cell(newSex, newLocation));
                    }
                }
            }
            
            foreach(var kid in kids)
            {
                population.Add(kid);
            }
        }

        // make out - заняться сексом 
        private bool LetsMakeOut(Cell male, Cell female)
        {
            var sexRadius = 5;
            return (   Math.Abs(male.Location.X - female.Location.X) <= sexRadius // если клетки находятся друг от друга в радиусе n пикселей,
                    && Math.Abs(male.Location.Y - female.Location.Y) <= sexRadius // то они могут сделать ребёнка
                    && male.Sex != female.Sex
                    );
        }
    }
}
