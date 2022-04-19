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
    internal class Lingkaran : Asset3d
    {
        public Vector3 objectCenter = Vector3.Zero;
        public Lingkaran(Vector3 color) : base(color)
        {
            this.color = color;
            /*_euler.Add(Vector3.UnitX);
            _euler.Add(Vector3.UnitY);
            _euler.Add(Vector3.UnitZ);*/
        }

        public void createEllipsoid(float _x, float _y, float _z, float radX, float radY, float radZ)
        {
            objectCenter = new Vector3(_x, _y, _z);

            Vector3 temp_vector;
            float _pi = 3.14f;

            for (float v = _pi / 2; v <= _pi; v += 0.001f)
            {
                for (float u = -_pi; u <= _pi; u += _pi / 30)
                {
                    temp_vector.X = _x + radX * (float)Math.Cos(v) * (float)Math.Cos(u);
                    temp_vector.Y = _y + radY * (float)Math.Cos(v) * (float)Math.Sin(u);
                    temp_vector.Z = _z + radZ * (float)Math.Sin(v);
                    vertices.Add(temp_vector);
                }
            }
        }

        public void createHalfEllipsoid(float x, float y, float z, float radX, float radY, float radZ)
        {
            objectCenter = new Vector3(x, y, z);

            Vector3 temp_vector;
            float _pi = 3.14f;

            for (float v = -_pi / 2; v <= _pi / 2; v += 0.001f)
            {
                for (float u = -_pi; u <= 0; u += _pi / 30)
                {
                    temp_vector.X = x + radX * (float)Math.Cos(v) * (float)Math.Cos(u);
                    temp_vector.Y = y + radY * (float)Math.Cos(v) * (float)Math.Sin(u);
                    temp_vector.Z = z + radZ * (float)Math.Sin(v);
                    vertices.Add(temp_vector);
                }
            }
        }
    }
}
