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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void startgame_Click(object sender, EventArgs e)
        {
            Form1 abc = new Form1();
            this.Hide();
            abc.ShowDialog();
            this.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {
            string tekst = "Gra polega na dotarciu kursorem myszy z zielonego do czeronego pola.\nNie wolno tratić w czarne pole, można poruszać sie tylko po białym.\nW grze mogą być ukryte mapy.\n\nOsoby z wadami serca nie powinny grać w tą gre.\nWykonał Błażej Darowski"; 
            MessageBox.Show(tekst, "Maze | Help");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
