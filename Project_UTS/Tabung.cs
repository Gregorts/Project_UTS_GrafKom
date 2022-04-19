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
        public Tabung(Vector3 color) : base(color)
        {
            this.color = color;
            /*_euler.Add(Vector3.UnitX);
            _euler.Add(Vector3.UnitY);
            _euler.Add(Vector3.UnitZ);*/
        }

        public void createTube(float x_c, float y_c, float z_c, uint segments, float radius, float height)
        {
            for (double y = 0; y < 2; y++)
            {
                for (double x = 0; x < segments; x++)
                {
                    double theta = (x / (segments - 1)) * 2 * Math.PI;

                    vertices.Add(new Vector3()
                    {
                        X = (float)(radius * Math.Cos(theta)) + x_c,
                        Y = (float)(height * y) + y_c,
                        Z = (float)(radius * Math.Sin(theta)) + z_c,
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
    }
}
