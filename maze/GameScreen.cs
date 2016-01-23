using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Drawing;

namespace maze
{
    class GameScreen : GameWindow
    {
        //textures
        Texture2D title_screen;
        Texture2D title_exit;
        Texture2D title_high;
        Texture2D title_start;
        Texture2D sand;
        Texture2D wall;
        //game state
        string game_state = "title screen";

        public GameScreen(int width, int height)
            : base(width, height)
        {
            GL.Enable(EnableCap.Texture2D);
            Input.Initialize(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            title_screen = ContentPipe.LoadTexture("title_screen.png");
            title_exit = ContentPipe.LoadTexture("menu_exit.png");
            title_high = ContentPipe.LoadTexture("menu_high.png");
            title_start = ContentPipe.LoadTexture("menu_start.png");
            sand = ContentPipe.LoadTexture("sand.png");
            wall = ContentPipe.LoadTexture("wall.png");
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            switch (game_state)
            {
                case "title screen":
                    //exit pressed
                    if (Input.KeyPress(OpenTK.Input.MouseButton.Left) && Mouse.X > 959 && Mouse.Y > 556 && Mouse.X < 959 + title_exit.Width && Mouse.Y < 556 + title_exit.Height)
                        this.Close();
                    if (Input.KeyPress(OpenTK.Input.MouseButton.Left) && Mouse.X > 467 && Mouse.Y > 458 && Mouse.X < 467 + title_start.Width && Mouse.Y < 458 + title_start.Height)
                        game_state = "game";
                    //start pressed

                    //high score pressed

                    break;
            }
            if (Input.KeyPress(OpenTK.Input.MouseButton.Left))
            {
                Console.WriteLine("X=" + Mouse.X + " Y=" + Mouse.Y);
            }
            Input.Update();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);
            Spritebatch.Begin(this.Width, this.Height);
                    Spritebatch.Draw(title_screen, new Vector2(-this.Width / 2, -this.Height / 2), new Vector2(1f, 1f), Color.Transparent, new Vector2(0, 0));
                    if (Mouse.X > 959 && Mouse.Y > 556 && Mouse.X < 959 + title_exit.Width && Mouse.Y < 556 + title_exit.Height) //if hovers over exit button
                        Spritebatch.Draw(title_exit, new Vector2(-this.Width / 2 + 959, -this.Height / 2 + 556), new Vector2(1f, 1f), Color.Transparent, new Vector2(0, 0));
                    if (Mouse.X > 153 && Mouse.Y > 647 && Mouse.X < 153 + title_high.Width && Mouse.Y < 647 + title_high.Height) //if hovers over high score button
                        Spritebatch.Draw(title_high, new Vector2(-this.Width / 2 + 153, -this.Height / 2 + 647), new Vector2(1f, 1f), Color.Transparent, new Vector2(0, 0));
                    if (Mouse.X > 467 && Mouse.Y > 458 && Mouse.X < 467 + title_start.Width && Mouse.Y < 458 + title_start.Height) //if hovers over start button
                        Spritebatch.Draw(title_start, new Vector2(-this.Width / 2 + 467, -this.Height / 2 + 458), new Vector2(1f, 1f), Color.Transparent, new Vector2(0, 0));

            this.SwapBuffers();
        }
    }
}
