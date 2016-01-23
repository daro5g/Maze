using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Input;

namespace maze
{
    class Input
    {
        private static List<Key> keysDown;
        private static List<Key> keysDownLast;
        private static List<MouseButton> buttonDown;
        private static List<MouseButton> buttonDownLast;

        public static void Initialize(GameScreen game)
        {
            keysDown = new List<Key>();
            keysDownLast = new List<Key>();
            buttonDown = new List<MouseButton>();
            buttonDownLast = new List<MouseButton>();

            game.KeyDown += Game_KeyDown;
            game.KeyUp += Game_KeyUp;
            game.MouseDown += Game_MouseDown;
            game.MouseUp += Game_MouseUp;
        }

        private static void Game_MouseUp(object sender, MouseButtonEventArgs e)
        {
            while (buttonDown.Contains(e.Button))
                buttonDown.Remove(e.Button);
        }

        private static void Game_MouseDown(object sender, MouseButtonEventArgs e)
        {
            buttonDown.Add(e.Button);
        }

        private static void Game_KeyUp(object sender, KeyboardKeyEventArgs e)
        {
            while (keysDown.Contains(e.Key))
                keysDown.Remove(e.Key);
        }

        private static void Game_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            keysDown.Add(e.Key);
        }

        public static void Update()
        {
            keysDownLast = new List<Key>(keysDown);
            buttonDownLast = new List<MouseButton>(buttonDown);
        }

        public static bool KeyPress(Key key)
        {
            return (keysDown.Contains(key) && !keysDownLast.Contains(key));
        }

        public static bool KeyRelease(Key key)
        {
            return (!keysDown.Contains(key) && keysDownLast.Contains(key));
        }

        public static bool KeyDown(Key key)
        {
            return (keysDown.Contains(key));
        }

        public static bool KeyPress(MouseButton button)
        {
            return (buttonDown.Contains(button) && !buttonDownLast.Contains(button));
        }

        public static bool KeyRelease(MouseButton button)
        {
            return (!buttonDown.Contains(button) && buttonDownLast.Contains(button));
        }

        public static bool KeyDown(MouseButton button)
        {
            return (buttonDown.Contains(button));
        }
    }
}
