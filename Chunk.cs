using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Media3D;
using SharpGL;

namespace MinecraftSharp
{
    class Chunk
    {
        private const short Width = 16;
        private const short Height = 64;
        private 
        Block[] blocks = new Block[Width * Width * Height];//split into horizontal squares bottom up, then north-south from bottom like reading
        Vector localCoord;

        public Chunk(Vector coord)
        {
            localCoord = coord;
        }

        public void AddBlock(Block block)
        {
            /*
             y=0
              240,241,242,243,244,245,   ... 255
              ...
              16, 17, 18, 19, 20, 21, 22 ... 31,
        start 0,  1,  2,  3,  4,  5,  6  ... 15,
             y=1
               256,257,258,259...
             */
            block.Parent = this;
            blocks[(int)(block.LocalCoord.Y * 256 + block.LocalCoord.Z * 16 + block.LocalCoord.X)] = block;
            //           y level                    north-south               east-west
        }
    }
}
