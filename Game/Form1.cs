using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Well Done");
            Close();
        }

        private void StartMouse()
        {
            Point start = game_board.Location;
            start.Offset(10, 10);
            Cursor.Position = PointToScreen(start);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            StartMouse();
        }
    }
}
