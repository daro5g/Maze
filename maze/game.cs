using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    class game
    {

        public map[,] board = new map[10, 10];

        public struct map
        {
            public bool wall;
            public bool sand;
            public bool player;
            public bool finish;
            public bool start;
        }

        public game()
        {
            initialise();
        }

        private void initialise()
        {
            
        }

    }
}
