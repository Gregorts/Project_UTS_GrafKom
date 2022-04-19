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
    internal class Balok : Asset3d
    {

        float lengthX;
        float lengthY;
        float lengthZ;
        public Balok(Vector3 color) : base (color)
        {
            this.color = color;
            /*_euler.Add(Vector3.UnitX);
            _euler.Add(Vector3.UnitY);
            _euler.Add(Vector3.UnitZ);*/
        }

        public void createCuboid(float _x, float _y, float _z, float length_x, float length_y, float length_z)
        {
            this.posX = _x;
            this.posY = _y;
            this.posZ = _z;

            this.lengthX = length_x;
            this.lengthY = length_y;
            this.lengthZ = length_z;

            var tempVertices = new List<Vector3>();
            Vector3 temp_vector;

            //Titik 1
            temp_vector.X = _x - length_x / 2.0f;
            temp_vector.Y = _y + length_y / 2.0f;
            temp_vector.Z = _z - length_z / 2.0f;
            tempVertices.Add(temp_vector);

            //Titik 2
            temp_vector.X = _x + length_x / 2.0f;
            temp_vector.Y = _y + length_y / 2.0f;
            temp_vector.Z = _z - length_z / 2.0f;
            tempVertices.Add(temp_vector);

            //Titik 3
            temp_vector.X = _x - length_x / 2.0f;
            temp_vector.Y = _y - length_y / 2.0f;
            temp_vector.Z = _z - length_z / 2.0f;
            tempVertices.Add(temp_vector);

            //Titik 4
            temp_vector.X = _x + length_x / 2.0f;
            temp_vector.Y = _y - length_y / 2.0f;
            temp_vector.Z = _z - length_z / 2.0f;
            tempVertices.Add(temp_vector);

            //Titik 5
            temp_vector.X = _x - length_x / 2.0f;
            temp_vector.Y = _y + length_y / 2.0f;
            temp_vector.Z = _z + length_z / 2.0f;
            tempVertices.Add(temp_vector);

            //Titik 6
            temp_vector.X = _x + length_x / 2.0f;
            temp_vector.Y = _y + length_y / 2.0f;
            temp_vector.Z = _z + length_z / 2.0f;
            tempVertices.Add(temp_vector);

            //Titik 7
            temp_vector.X = _x - length_x / 2.0f;
            temp_vector.Y = _y - length_y / 2.0f;
            temp_vector.Z = _z + length_z / 2.0f;
            tempVertices.Add(temp_vector);

            //Titik 8
            temp_vector.X = _x + length_x / 2.0f;
            temp_vector.Y = _y - length_y / 2.0f;
            temp_vector.Z = _z + length_z / 2.0f;
            tempVertices.Add(temp_vector);

            var tempIndices = new List<uint>
            {
				//Back
				1, 2, 0,
                2, 1, 3,
				
				//Top
				5, 0, 4,
                0, 5, 1,

				//Right
				5, 3, 1,
                3, 5, 7,

				//Left
				0, 6, 4,
                6, 0, 2,

				//Front
				4, 7, 5,
                7, 4, 6,

				//Bottom
				3, 6, 2,
                6, 3, 7
            };
            vertices = tempVertices;
            indices = tempIndices;
        }
    }
}
