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
        public Vector3 objectCenter;
        float RadX, RadY, RadZ;
        public Lingkaran(Vector3 color, Vector3 pos) : base(color, pos)
        {
            this.color = color;
            this.posX = pos.X;
            this.posY = pos.Y;
            this.posZ = pos.Z;
            RadX = 0;
            RadY = 0;
            RadZ = 0;
            /*_euler.Add(Vector3.UnitX);
            _euler.Add(Vector3.UnitY);
            _euler.Add(Vector3.UnitZ);*/
        }

        public void createSphere(float _x, float _y, float _z, float radX, float radY, float radZ, int sectorCount, int stackCount)
        {
            objectCenter = new Vector3(_x, _y, _z);
            RadX = radX;
            RadY = radY;
            RadZ = radZ;

            float pi = (float)Math.PI;
            Vector3 temp_vector;
            float sectorStep = 2 * pi / sectorCount;
            float stackStep = pi / stackCount;
            float sectorAngle, stackAngle;

            for (int i = 0; i <= stackCount; ++i)
            {
                stackAngle = pi / 2 - i * stackStep;
                posX = RadX * (float)Math.Cos(stackAngle);
                posY = RadY * (float)Math.Sin(stackAngle);
                posZ = RadZ * (float)Math.Cos(stackAngle);

                for (int j = 0; j <= sectorCount; ++j)
                {
                    sectorAngle = j * sectorStep;

                    temp_vector.X = _x + posX * (float)Math.Cos(sectorAngle);
                    temp_vector.Y = _y + posY;
                    temp_vector.Z = _z + posZ * (float)Math.Sin(sectorAngle);

                    vertices.Add(temp_vector);
                }
            }

            posX = objectCenter.X;
            posY = objectCenter.Y;
            posZ = objectCenter.Z;

            uint k1, k2;
            for (int i = 0; i < stackCount; ++i)
            {
                k1 = (uint)(i * (sectorCount + 1));
                k2 = (uint)(k1 + sectorCount + 1);

                for (int j = 0; j < sectorCount; ++j, ++k1, ++k2)
                {
                    if (i != 0)
                    {
                        indices.Add(k1);
                        indices.Add(k2);
                        indices.Add(k1 + 1);

                    }

                    if (i != stackCount - 1)
                    {
                        indices.Add(k1 + 1);
                        indices.Add(k2);
                        indices.Add(k2 + 1);
                    }
                }
            }
        }

        public void createHalfSphere(float _x, float _y, float _z, float radX, float radY, float radZ, float sectorCount, float stackCount)
        {
            objectCenter = new Vector3(_x, _y, _z);
            RadX = radX;
            RadY = radY;
            RadZ = radZ;

            float pi = (float)Math.PI;
            Vector3 temp_vector;
            float sectorStep = 2 * pi / sectorCount;
            float stackStep = pi / stackCount;
            float sectorAngle, stackAngle;

            for (int i = 0; i <= stackCount; ++i)
            {
                stackAngle = pi / 2 - i * stackStep;
                posX = RadX * (float)Math.Cos(stackAngle);
                posY = RadY * (float)Math.Cos(stackAngle);
                posZ = RadZ * (float)Math.Sin(stackAngle);

                for (int j = 0; j <= sectorCount; ++j)
                {
                    sectorAngle = j * sectorStep;

                    temp_vector.X = _x + posX * (float)Math.Cos(sectorAngle);
                    temp_vector.Y = _y + posY * (float)Math.Sin(sectorAngle);
                    temp_vector.Z = _z + posZ;

                    vertices.Add(temp_vector);
                }
            }

            posX = objectCenter.X;
            posY = objectCenter.Y;
            posZ = objectCenter.Z;

            uint k1, k2;
            for (int i = 0; i < stackCount; ++i)
            {
                k1 = (uint)(i * (sectorCount + 1));
                k2 = (uint)(k1 + sectorCount + 1);

                for (int j = 0; j < sectorCount/2; ++j, ++k1, ++k2)
                {
                    if (i != 0)
                    {
                        indices.Add(k1);
                        indices.Add(k2);
                        indices.Add(k1 + 1);

                    }

                    if (i != stackCount - 1)
                    {
                        indices.Add(k1 + 1);
                        indices.Add(k2);
                        indices.Add(k2 + 1);
                    }
                }
            }
        }

        public float getradx() { return RadX; }

        public float getrady() { return RadY; }

        public float getradz() { return RadZ; }
    }
}
