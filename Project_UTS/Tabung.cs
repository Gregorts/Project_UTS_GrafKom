using LearnOpenTK.Common;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Tabung : Asset3d
    {
        float Radius, Height;
        public Tabung(Vector3 color, Vector3 pos) : base(color, pos)
        {
            this.color = color;
            this.posX = pos.X;
            this.posY = pos.Y;
            this.posZ = pos.Z;
            Radius = 0;
            Height = 0;
            /*_euler.Add(Vector3.UnitX);
            _euler.Add(Vector3.UnitY);
            _euler.Add(Vector3.UnitZ);*/
        }

        public void createTube(float _x, float _y, float _z, uint segments, float radius, float height)
        {
            Radius = radius;
            Height = height;
            for (double y = 0; y < 2; y++)
            {
                for (double x = 0; x < segments; x++)
                {
                    double theta = (x / (segments - 1)) * 2 * Math.PI;

                    posX = (float)(Radius * Math.Cos(theta)) + _x;
                    posY = (float)(Height * y) + _y;
                    posZ = (float)(Radius * Math.Sin(theta)) + _z;

                    vertices.Add(new Vector3()
                    {
                        X = posX,
                        Y = posY,
                        Z = posZ,
                    });
                }
            }
            for (uint x = 0; x < segments - 1; x++)
            {
                indices.Add(x);
                indices.Add(x + segments);
                indices.Add(x + segments + 1);

                indices.Add(x + segments + 1);
                indices.Add(x + 1);
                indices.Add(x);
            }
        }
        public float getrad()
        {
            return Radius;
        }

        public float getheight()
        {
            return Height;
        }
    }
}
