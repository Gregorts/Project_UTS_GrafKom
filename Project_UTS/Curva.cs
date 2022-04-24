using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Curva : Asset3d
    {
        float RadiusX;
        float RadiusZ;
        float Height;
        float Extended;

        public Curva(Vector3 color, Vector3 pos) : base(color, pos)
        {
            this.color = color;
            posX = pos.X;
            posY = pos.Y;
            posZ = pos.Z;

            RadiusX = 0f;
            Height = 0f;
            RadiusZ = 0f;
            Extended = 0f;
        }

        public void createEllipsoidVertices(float _x, float _y, float _z, float radiusX, float height, float radiusZ, float extended)
        {
            posX = _x;
            posY = _y;
            posZ = _z;
            RadiusX = radiusX;
            RadiusZ = radiusZ;
            Height = height;
            Extended = extended;

            Vector3 temp_vector;
            float _pi = (float)Math.PI;

            for (float v = -Height / 2; v <= (Height / 2); v += 0.0001f)
            {
                Vector3 p = setBeizer((v + (Height / 2)) / Height);
                for (float u = -_pi; u <= _pi; u += (_pi / 30))
                {
                    temp_vector.X = p.X + RadiusX * (float)Math.Cos(u);
                    temp_vector.Y = p.Y + RadiusZ * (float)Math.Sin(u);
                    temp_vector.Z = posZ + v;

                    vertices.Add(temp_vector);

                }
            }
            Console.WriteLine("vertices -> " + vertices.ToArray());
        }

        public float getExtended() { return Extended; }

        Vector3 setBeizer(float t)
        {
            //Console.WriteLine(t);
            Vector3 p = new Vector3(0f, 0f, 0f);
            float[] k = new float[3];

            k[0] = (float)Math.Pow((1 - t), 3 - 1 - 0) * (float)Math.Pow(t, 0) * 1;
            k[1] = (float)Math.Pow((1 - t), 3 - 1 - 1) * (float)Math.Pow(t, 1) * 2;
            k[2] = (float)Math.Pow((1 - t), 3 - 1 - 2) * (float)Math.Pow(t, 2) * 1;


            //titik 1
            p.X += k[0] * posX;
            p.Y += k[0] * posY - Height;

            //titik 2
            p.X += k[1] * (posX + Extended);
            p.Y += k[1] * posY;

            //titik 3
            p.X += k[2] * posX;
            p.Y += k[2] * posY + Height;

            //Console.WriteLine(p.X + " "+ p.Y);

            return p;
        }
    }
}
