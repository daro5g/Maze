using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private Point StartPoint;
        private bool isGame = true;
        int nrmapy = 0;
        int cos = 15;
        public Form1()
        {
            InitializeComponent();
            la.Visible = false;
            Wygrana();
        }

        private void StartMouse()
        {
            Cursor.Position = PointToScreen(StartPoint);
        }

        private void game_board1_MouseMove(object sender, MouseEventArgs e)
        {
            if(cos-- <= 0)
            {
                cos = 15;
                GC.Collect();
            }else
            {
                return;
            }
            //MessageBox.Show(e.X +" "+ e.Y);
            //return;
            if (isGame)
            {
                try
                {
                    var pixelcolor = ((Bitmap)game_board1.Image).GetPixel(e.X, e.Y);
                    //MessageBox.Show(pixelcolor.ToString());
                    //return;
                    if (pixelcolor.R <= 30 && pixelcolor.G <= 30 && pixelcolor.B <= 30 && pixelcolor.A >= 230)
                        StartMouse();
                    if (pixelcolor.R >= 220 && pixelcolor.G <= 50 && pixelcolor.B <= 50 && pixelcolor.A >= 200)
                        Wygrana();
                }
                catch { }
            }
        }

        private void Wygrana()
        {
            nrmapy++;
            switch (nrmapy)
            {
                case 1:
                    game_board1.Image = Game.Properties.Resources.lvl1;
                    StartPoint = game_board1.Location;
                    StartPoint.Offset(200, 23);
                    StartMouse();
                    break;
                case 2:
                    game_board1.Image = Game.Properties.Resources.lvl2;
                    StartPoint = game_board1.Location;
                    StartPoint.Offset(472, 462);
                    StartMouse();
                    break;
                case 3:
                    game_board1.Image = Game.Properties.Resources.lvl3;
                    la.Visible = true;
                    StartPoint = game_board1.Location;
                    StartPoint.Offset(254, 468);
                    StartMouse();
                    break;
            }
        }

        private void LastWin()
        {
            isGame = false;
            game_board1.SizeMode = PictureBoxSizeMode.StretchImage;
            game_board1.Image = Game.Properties.Resources.scary_maze_game_tribute;
            SoundPlayer sp = new SoundPlayer(Game.Properties.Resources.sound1);
            sp.Play();

        }

        private void la_MouseEnter(object sender, EventArgs e)
        {
            if (isGame)
            {
                la.Visible = false;
                LastWin();
            }
        }
    }
}
