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
        float radius;
        float height;
        public Tabung(Vector3 color) : base(color)
        {
            this.color = color;
            /*_euler.Add(Vector3.UnitX);
            _euler.Add(Vector3.UnitY);
            _euler.Add(Vector3.UnitZ);*/
        }
        /*public void createEllipsoidVertices(float _X, float _Y, float _Z, float _radius, float _height)
        {
            this.posX = _X;
            this.posY = _Y;
            this.posZ = _Z;
            this.radius = _radius;
            this.height = _height;

            Vector3 temp_vector;
            float _pi = (float)Math.PI;


            for (float v = -_height / 2; v <= (_height / 2); v += 0.0005f)
            {
                for (float u = -_pi; u <= _pi; u += (_pi / 30))
                {
                    temp_vector.X = _X + _radius * (float)Math.Cos(u);
                    temp_vector.Y = _Y + _radius * (float)Math.Sin(u);
                    temp_vector.Z = _Z + v;

                    vertices.Add(temp_vector);
                }
            }
        }*/

        public void createCone(float _x, float _y, float _z, float radiusTop, float radiusBottom, float height, float slices)
        {
            Vector3 temp_vector;
            float sliceArc = 360.0f / (float)slices;
            float angle = 0;
            for (int i = 0; i < slices; i++)
            {
                temp_vector.X = _x + radiusBottom * (float)Math.Cos(MathHelper.DegreesToRadians(angle));
                temp_vector.Y = _y + 0;
                temp_vector.Z = _z + radiusBottom * (float)Math.Sin(MathHelper.DegreesToRadians(angle));
                vertices.Add(temp_vector);

                temp_vector.X = _x + radiusTop * (float)Math.Cos(MathHelper.DegreesToRadians(angle));
                temp_vector.Y = _y + height;
                temp_vector.Z = _z + radiusTop * (float)Math.Sin(MathHelper.DegreesToRadians(angle));

                vertices.Add(temp_vector);
                angle += sliceArc;
            }
            GL.DrawArrays(PrimitiveType.TriangleFan, 30, vertices.Count);

        }
    }
}
