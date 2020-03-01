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
        List<Cell> population = new List<Cell>()
        { 
            new Cell(Sex.Man, new Point(215, 215)), 
            new Cell(Sex.Woman, new Point(255, 255)) 
        };

        private Graphics graphics;
        private SolidBrush figure = new SolidBrush(Color.Blue);

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox.CreateGraphics();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pictureBox.Refresh();
            foreach (var cell in population)
            {
                cell.Run();
                graphics.FillEllipse(cell.Color, cell.Location.X, cell.Location.Y, Cell.Radius, Cell.Radius);
            }
        }
    }
}
