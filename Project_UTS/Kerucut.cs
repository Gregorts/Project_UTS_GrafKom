using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Kerucut : Asset3d
    {
        float Radius, Height;
        public Kerucut(Vector3 color, Vector3 pos) : base(color, pos)
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

        public void createCone(float _x, float _y, float _z, float radius, float height, float slices)
        {
            Vector3 temp_vector;
            float sliceArc = 360.0f / (float)slices;
            float angle = 0;
            Radius = radius;
            Height = height;
            for (int i = 0; i < slices; i++)
            {
                temp_vector.X = _x + Radius * (float)Math.Cos(MathHelper.DegreesToRadians(angle));
                temp_vector.Y = _y + 0;
                temp_vector.Z = _z + Radius * (float)Math.Sin(MathHelper.DegreesToRadians(angle));
                vertices.Add(temp_vector);

                temp_vector.X = _x;
                temp_vector.Y = _y + Height;
                temp_vector.Z = _z;

                vertices.Add(temp_vector);
                angle += sliceArc;
            }
            //GL.DrawArrays(PrimitiveType.TriangleFan, 30, vertices.Count);

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
