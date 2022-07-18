using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;

namespace MinecraftSharp
{
    class Program
    {

        static void Main()
        {
            using(Game game = new Game(900, 600, "Minecraft Sharp"))
            {
                game.Run(50);//fps
            }
        }
    }
}
