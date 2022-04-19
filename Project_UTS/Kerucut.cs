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
        public Kerucut(Vector3 color) : base(color)
        {
            this.color = color;
            /*_euler.Add(Vector3.UnitX);
            _euler.Add(Vector3.UnitY);
            _euler.Add(Vector3.UnitZ);*/
        }

        public void createCone(float _x, float _y, float _z, float radius, float height, float slices)
        {
            Vector3 temp_vector;
            float sliceArc = 360.0f / (float)slices;
            float angle = 0;
            for (int i = 0; i < slices; i++)
            {
                temp_vector.X = _x + radius * (float)Math.Cos(MathHelper.DegreesToRadians(angle));
                temp_vector.Y = _y + 0;
                temp_vector.Z = _z + radius * (float)Math.Sin(MathHelper.DegreesToRadians(angle));
                vertices.Add(temp_vector);

                temp_vector.X = _x;
                temp_vector.Y = _y + height;
                temp_vector.Z = _z;

                vertices.Add(temp_vector);
                angle += sliceArc;
            }
            //GL.DrawArrays(PrimitiveType.TriangleFan, 30, vertices.Count);

        }
    }
}
