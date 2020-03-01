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
        // в начале всего были Адам и Ева
        List<Cell> population = new List<Cell>()
        { 
            new Cell(Sex.Male, new Point(200, 200)), 
            new Cell(Sex.Female, new Point(150, 200)) 
        };

        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox.CreateGraphics();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            List<Cell> kids = new List<Cell>(); // здесь будут дети, появшиеся от пересечения 
            pictureBox.Refresh();
            
            foreach (var cell in population)
            {
                cell.Run();
                graphics.FillEllipse(cell.Color, cell.Location.X, cell.Location.Y, Cell.Radius, Cell.Radius);
            }

            // когда все сделали ход, ищем любовничков
            for (int i = 0; i < population.Count; i++)
            {
                for (int j = i; j < population.Count; j++)
                {
                    if (LetsMakeOut(population[i], population[j]))
                    {
                        // новый гендерный пол
                        Random randSex = new Random();
                        Sex newSex = (Sex)randSex.Next(0, 2);

                        // новая локация, так как делать клетку на месте рождения - самоубийство
                        // они начинают плодиться в геометрической прогрессии. Разом.
                        // пускай рождаются в радиусе 100 пикселей
                        Random randLocation = new Random();
                        int bornRadius = 50;
                        int bornX = population[j].Location.X + randLocation.Next(-bornRadius, bornRadius);
                        int bornY = population[j].Location.Y + randLocation.Next(-bornRadius, bornRadius);
                        Point newLocation = new Point(bornX, bornY);

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
            int sexRaduis = 5;
            return (//male.Location == female.Location // так мало клеток наплодится, а ниже - много
                    Math.Abs(male.Location.X - female.Location.X) <= sexRaduis    // если клетки находятся друг от друга в радиусе 5 пикселей,
                    && Math.Abs(male.Location.Y - female.Location.Y) <= sexRaduis // то они могут сделать ребёнка
                    && male.Sex != female.Sex
                    );
        }
    }
}
