using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Windows;

namespace MinecraftSharp
{
    class World
    {
        private const short Chunk_Radius = 16;
        private const short Sea_Level = 30;
        private Chunk[] Quad1 = new Chunk[Chunk_Radius * Chunk_Radius];//north
        private Chunk[] Quad2 = new Chunk[Chunk_Radius * Chunk_Radius];
        private Chunk[] Quad3 = new Chunk[Chunk_Radius * Chunk_Radius];
        private Chunk[] Quad4 = new Chunk[Chunk_Radius * Chunk_Radius];

        public World()
        {
            for (int z = 0; z < Chunk_Radius; z++)
            {
                for (int x = 0; x < Chunk_Radius; x++)
                {
                    Quad1[16 * z + x] = new Chunk(new Vector(x, z));
                    Quad2[16 * z + x] = new Chunk(new Vector(x - 1, z));
                    Quad3[16 * z + x] = new Chunk(new Vector(x - 1, z - 1));
                    Quad4[16 * z + x] = new Chunk(new Vector(x, z - 1));
                    ChunkFill(Quad1[16 * z + x]);
                    ChunkFill(Quad2[16 * z + x]);
                    ChunkFill(Quad3[16 * z + x]);
                    ChunkFill(Quad4[16 * z + x]);
                }
            }
        } 

        private void ChunkFill(Chunk chunk)
        {
            for (int y = 0; y < 64; y++)
            {
                for (int z = 0; z < 16; z++)
                {
                    for (int x = 0; x < 16; x++)
                    {
                        chunk.AddBlock(new Block(new Vector3D(x, y, z)));
                    }
                }
            }
        }
    }
}
