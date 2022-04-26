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
    class Asset3d
    {
        private readonly string path = "../../../Shader/";

        protected List<Vector3> vertices = new List<Vector3>();
        protected List<uint> indices = new List<uint>();

        protected int _vertexBufferObject;
        protected int _vertexArrayObject;
        protected int _elementBufferObject;

        protected Shader _shader;

        protected Matrix4 model = Matrix4.Identity;   // Model Matrix      ==> Matrix ini yang akan berubah saat terjadi transformasi
        protected Matrix4 view;                       // View Matrix       ==> Matrix ini menentukan arah pandang 'kamera'
        protected Matrix4 projection;                 // Projection Matrix ==> Matrix ini menentukan jenis projection, kamera game cenderung menggunakan kamera perspective.

        protected Vector3 color;                      // Warna objek, dikirim ke shader lewat uniform.

        protected float posX;
        protected float posY;
        protected float posZ;

        protected float _size = 1;


        int animate = 0;

        //public List<Vector3> _euler = new List<Vector3>();  // Sudut lokal, relatif terhadap objek yang bersangkutan.
        //public Vector3 objectCenter = Vector3.Zero;         // Titik tengah objek

        //public List<Asset3d> child = new List<Asset3d>();   // Sistem Hierarchical Object ==> List untuk menampung objek - objek child.

        public Asset3d(Vector3 color, Vector3 pos)
        {
            this.color = color;
            posX = pos.X;
            posY = pos.Y;
            posZ = pos.Z;
            /*_euler.Add(Vector3.UnitX); // Masukkan sudut Euler di Constructor.
            _euler.Add(Vector3.UnitY);
            _euler.Add(Vector3.UnitZ);*/
        }

        public void load(int sizeX, int sizeY)
        {
            _vertexBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Count * Vector3.SizeInBytes, vertices.ToArray(), BufferUsageHint.StaticDraw);

            _vertexArrayObject = GL.GenVertexArray();
            GL.BindVertexArray(_vertexArrayObject);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);

            _elementBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, _elementBufferObject);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Count * sizeof(uint), indices.ToArray(), BufferUsageHint.StaticDraw);

            view = Matrix4.CreateTranslation(0, 0, -8.0f);
            projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), sizeX / (float)sizeY, 0.01f, 100f);

            _shader = new Shader(path + "Shader.vert", path + "Shader.frag");
            _shader.Use();

            /*foreach (var i in child)
            {
                i.load(sizeX, sizeY);
            }*/
        }

        public void render()
        {
            _shader.Use();
            

            _shader.SetVector3("objColor", color);

            //model *= Matrix4.CreateRotationY((float)MathHelper.DegreesToRadians(time));

            _shader.SetMatrix4("model", model);

            //GL.DrawArrays(PrimitiveType.LineStrip, 0, vertices.Count);

            GL.BindVertexArray(_vertexArrayObject);

            if (indices.Count != 0)
            {
                GL.DrawElements(PrimitiveType.Triangles, indices.Count, DrawElementsType.UnsignedInt, 0);
            }
            else
            {
                GL.DrawArrays(PrimitiveType.LineStrip, 0, vertices.Count);
            }
            /*foreach (var i in child)
            {
                i.render(time);
            }*/
        }

        /// <summary>
        /// Berfungsi untuk me-reset sudut euler (sudut relatif terhadap objek)
        /// </summary>
        /*public void resetEuler()
        {
            _euler.Clear();
            _euler.Add(Vector3.UnitX);
            _euler.Add(Vector3.UnitY);
            _euler.Add(Vector3.UnitZ);
        }*/

        /*#region solidObjects

        

        public void createTorus(float x, float y, float z, float radMajor, float radMinor, float sectorCount, float stackCount)
        {
            objectCenter = new Vector3(x, y, z);

            float pi = (float)Math.PI;
            Vector3 temp_vector;
            stackCount *= 2;
            float sectorStep = 2 * pi / sectorCount;
            float stackStep = 2 * pi / stackCount;
            float sectorAngle, stackAngle, tempX, tempY, tempZ;

            for (int i = 0; i <= stackCount; ++i)
            {
                stackAngle = pi / 2 - i * stackStep;
                tempX = radMajor + radMinor * (float)Math.Cos(stackAngle);
                tempY = radMinor * (float)Math.Sin(stackAngle);
                tempZ = radMajor + radMinor * (float)Math.Cos(stackAngle);

                for (int j = 0; j <= sectorCount; ++j)
                {
                    sectorAngle = j * sectorStep;

                    temp_vector.X = x + tempX * (float)Math.Cos(sectorAngle);
                    temp_vector.Y = y + tempY;
                    temp_vector.Z = z + tempZ * (float)Math.Sin(sectorAngle);

                    vertices.Add(temp_vector);
                }
            }

            uint k1, k2;
            for (int i = 0; i < stackCount; ++i)
            {
                k1 = (uint)(i * (sectorCount + 1));
                k2 = (uint)(k1 + sectorCount + 1);

                for (int j = 0; j < sectorCount; ++j, ++k1, ++k2)
                {
                    indices.Add(k1);
                    indices.Add(k2);
                    indices.Add(k1 + 1);

                    indices.Add(k1 + 1);
                    indices.Add(k2);
                    indices.Add(k2 + 1);
                }
            }
        }

        #endregion*/

        public Vector3 getPos() { return new Vector3(posX, posY, posZ); }

        public void rotate(float angle = 0.01f, char a = 'x')
        {
            switch (a)
            {
                case 'x': model = model * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(angle)); break;
                case 'y': model = model * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(angle)); break;
                case 'z': model = model * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angle)); break;
            }
            Matrix4 data = new Matrix4(
                posX, 0, 0, 0,
                0, posY, 0, 0,
                0, 0, posZ, 0,
                0, 0, 0, 1);

            data = model * data;

            posX = data.M11;
            posY = data.M22;
            posZ = data.M33;
        }

        public void rotatecenter(float angle = 0.01f, char a = 'x')
        {
            Vector4 pos = new Vector4(getPos());
            switch (a)
            {
                case 'x':
                    model = model * Matrix4.CreateTranslation(-1 * posX, -1 * posY, -1 * posZ) * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(angle)) * Matrix4.CreateTranslation(posX, posY, posZ);

                    pos = Matrix4.CreateTranslation(-1 * posX, -1 * posY, -1 * posZ) * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(angle)) * Matrix4.CreateTranslation(posX, posY, posZ) * pos;

                    break;
                case 'y':
                    model = model * Matrix4.CreateTranslation(-1 * posX, -1 * posY, -1 * posZ) * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(angle)) * Matrix4.CreateTranslation(posX, posY, posZ);

                    pos = Matrix4.CreateTranslation(-1 * posX, -1 * posY, -1 * posZ) * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(angle)) * Matrix4.CreateTranslation(posX, posY, posZ) * pos;

                    break;
                case 'z':
                    model = model * Matrix4.CreateTranslation(-1 * posX, -1 * posY, -1 * posZ) * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angle)) * Matrix4.CreateTranslation(posX, posY, posZ);

                    pos = Matrix4.CreateTranslation(-1 * posX, -1 * posY, -1 * posZ) * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angle)) * Matrix4.CreateTranslation(posX, posY, posZ) * pos;

                    break;
            }
        }

        public void rotatepoint(float angle = 90f, char a = 'y', Vector3 pos = new Vector3())
        {
            switch (a)
            {
                case 'x':
                    model = model * Matrix4.CreateTranslation(1 * pos.X, 1 * pos.Y, 1 * pos.Z) * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(angle)) * Matrix4.CreateTranslation(-pos.X, -pos.Y, -pos.Z);

                    break;
                /*case 'y':
                    model = model * Matrix4.CreateTranslation(1 * pos.X, 1 * pos.Y, 1 * pos.Z) * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(angle)) * Matrix4.CreateTranslation(-pos.X, -pos.Y, -pos.Z);

                    temp = pos;

                    temp.X = (float)Math.Cos(angle) * pos.Y - (float)Math.Sin(angle) * pos.Z;
                    temp.Z = (float)Math.Sin(angle) * pos.Y + (float)Math.Cos(angle) * pos.Z;

                    temp.X += (pos.X - posX);
                    temp.Y += (pos.Y - posY);
                    temp.Z += (pos.Z - posZ);

                    //temp.X = (float)Math.Cos(angle) * (   pos.X) - (float)Math.Sin(angle) * ( pos.Z) + (_positionX - pos.X);
                    //temp.Y = _positionY;
                    //temp.Z = (float)Math.Sin(angle) * (   pos.X) + (float)Math.Cos(angle) * ( pos.Z) + (_positionZ - pos.Z);

                break;
                case 'z':
                    model = model * Matrix4.CreateTranslation(1 * pos.X, 1 * pos.Y, 1 * pos.Z) * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angle)) * Matrix4.CreateTranslation(-pos.X, -pos.Y, -pos.Z);

                    temp.X = (float)Math.Cos(angle) * (pos.X) - (float)Math.Sin(angle) * (pos.Y) + (posX - pos.X);
                    temp.Y = (float)Math.Sin(angle) * (pos.X) + (float)Math.Cos(angle) * (pos.Y) + (posY - pos.Y);
                    temp.Z = posZ;

                    break;*/

            }
            posX = pos.X;
            posY = pos.Y;
            posZ = pos.Z;
        }

        public void animation(double time, float angle, char a, Vector3 pos)
        {
            if (animate <= 30)
            {
                translateup();
            }
            else if (animate > 30 && animate <= 42)
            {
                rotatepoint(angle, a, pos);
            }
            else if (animate > 42 && animate <= 72)
            {
                translatedown();
            }
            else if (animate > 72 && animate <= 80) { }
            else
            {
                animate = 0;
            }
            animate++;
            //Console.WriteLine(posX);
        }

        public void translateup()
        {
            Vector3 _translate = new Vector3();
            _translate.X = 0;
            _translate.Y = 1f;
            _translate.Z = 0;
            model *= Matrix4.CreateTranslation(_translate);
            posY += _translate.Y;
        }

        public void translatedown()
        {
            Vector3 _translate = new Vector3();
            _translate.X = 0;
            _translate.Y = -1f;
            _translate.Z = 0;
            model *= Matrix4.CreateTranslation(_translate);
        }

        public void translatefront()
        {
            Vector3 _translate = new Vector3();
            _translate.X = 0;
            _translate.Y = 0;
            _translate.Z = 1f;
            model *= Matrix4.CreateTranslation(_translate);
        }

        public void translateback()
        {
            Vector3 _translate = new Vector3();
            _translate.X = 0;
            _translate.Y = 0;
            _translate.Z = -1f;
            model *= Matrix4.CreateTranslation(_translate);
        }

        public void translateleft()
        {
            Vector3 _translate = new Vector3();
            _translate.X = -1f;
            _translate.Y = 0;
            _translate.Z = 0;
            model *= Matrix4.CreateTranslation(_translate);
        }

        public void translateright()
        {
            Vector3 _translate = new Vector3();
            _translate.X = 1f;
            _translate.Y = 0;
            _translate.Z = 0;
            model *= Matrix4.CreateTranslation(_translate);
        }

        public void reset(Vector3 pos)
        {
            model = Matrix4.CreateTranslation(pos);
        }

        public void CameraMovement(Camera _camera)
        {
            _shader.Use();

            _shader.SetMatrix4("model", model);
            _shader.SetMatrix4("view", _camera.GetViewMatrix());
            _shader.SetMatrix4("projection", _camera.GetProjectionMatrix());
        }

        public void scale(float m = 2)
        {
            if (m == 1)
            {
                model = model * Matrix4.CreateScale(1);
                return;
            }
            model = model * Matrix4.CreateScale(_size + m * _size);
            posX *= (_size + m * _size);
            posY *= (_size + m * _size);
            posZ *= (_size + m * _size);
        }

        public void scaledown()
        {
            model = model * Matrix4.CreateScale(_size - 0.05f * _size);
        }

        public void scaleup()
        {
            model = model * Matrix4.CreateScale(_size + 0.05f * _size);
        }

        /*public void translate(float length, char x)
        {
            Vector3 _translate = new Vector3();
            switch (x)
            {
                case 'j':
                    _translate.X = -length;
                    _translate.Y = 0;
                    _translate.Z = 0; break;
                case 'i':
                    _translate.X = 0;
                    _translate.Y = 0;
                    _translate.Z = -length; break;
                case 'k':
                    _translate.X = 0;
                    _translate.Y = 0;
                    _translate.Z = length; break;
                case 'l':
                    _translate.X = length;
                    _translate.Y = 0;
                    _translate.Z = 0; break;

                case 'x':
                    _translate.X = length;
                    _translate.Y = 0;
                    _translate.Z = 0; break;

                case 'y':
                    _translate.X = 0;
                    _translate.Y = length;
                    _translate.Z = 0; break;

                case 'z':
                    _translate.X = 0;
                    _translate.Y = 0;
                    _translate.Z = length; break;

            }

            model = model * Matrix4.CreateTranslation(_translate);

            posX += _translate.X;
            posY += _translate.Y;
            posZ += _translate.Z;
        }*/

        //public void scale(float scaleX, float scaleY, float scaleZ)
        //{
        //    model *= Matrix4.CreateTranslation(-objectCenter);
        //    model *= Matrix4.CreateScale(scaleX, scaleY, scaleZ);
        //    model *= Matrix4.CreateTranslation(objectCenter);

        //    foreach (var i in child)
        //    {
        //        i.scale(scaleX, scaleY, scaleZ);
        //    }
        //}

        //#region transforms
        /*public void rotate(Vector3 pivot, Vector3 vector, float angle)
        {
            var radAngle = MathHelper.DegreesToRadians(angle);

            var arbRotationMatrix = new Matrix4
                (
                new Vector4((float)(Math.Cos(radAngle) + Math.Pow(vector.X, 2.0f) * (1.0f - Math.Cos(radAngle))), (float)(vector.X * vector.Y * (1.0f - Math.Cos(radAngle)) + vector.Z * Math.Sin(radAngle)), (float)(vector.X * vector.Z * (1.0f - Math.Cos(radAngle)) - vector.Y * Math.Sin(radAngle)), 0),
                new Vector4((float)(vector.X * vector.Y * (1.0f - Math.Cos(radAngle)) - vector.Z * Math.Sin(radAngle)), (float)(Math.Cos(radAngle) + Math.Pow(vector.Y, 2.0f) * (1.0f - Math.Cos(radAngle))), (float)(vector.Y * vector.Z * (1.0f - Math.Cos(radAngle)) + vector.X * Math.Sin(radAngle)), 0),
                new Vector4((float)(vector.X * vector.Z * (1.0f - Math.Cos(radAngle)) + vector.Y * Math.Sin(radAngle)), (float)(vector.Y * vector.Z * (1.0f - Math.Cos(radAngle)) - vector.X * Math.Sin(radAngle)), (float)(Math.Cos(radAngle) + Math.Pow(vector.Z, 2.0f) * (1.0f - Math.Cos(radAngle))), 0),
                Vector4.UnitW
                );

            model *= Matrix4.CreateTranslation(-pivot);
            model *= arbRotationMatrix;
            model *= Matrix4.CreateTranslation(pivot);

            for (int i = 0; i < 3; i++)
            {
                _euler[i] = Vector3.Normalize(getRotationResult(pivot, vector, radAngle, _euler[i], true));
            }

            objectCenter = getRotationResult(pivot, vector, radAngle, objectCenter);

            foreach (var i in child)
            {
                i.rotate(pivot, vector, angle);
            }
        }

        public Vector3 getRotationResult(Vector3 pivot, Vector3 vector, float angle, Vector3 point, bool isEuler = false)
        {
            Vector3 temp, newPosition;

            if (isEuler)
            {
                temp = point;
            }
            else
            {
                temp = point - pivot;
            }

            newPosition.X =
                temp.X * (float)(Math.Cos(angle) + Math.Pow(vector.X, 2.0f) * (1.0f - Math.Cos(angle))) +
                temp.Y * (float)(vector.X * vector.Y * (1.0f - Math.Cos(angle)) - vector.Z * Math.Sin(angle)) +
                temp.Z * (float)(vector.X * vector.Z * (1.0f - Math.Cos(angle)) + vector.Y * Math.Sin(angle));

            newPosition.Y =
                temp.X * (float)(vector.X * vector.Y * (1.0f - Math.Cos(angle)) + vector.Z * Math.Sin(angle)) +
                temp.Y * (float)(Math.Cos(angle) + Math.Pow(vector.Y, 2.0f) * (1.0f - Math.Cos(angle))) +
                temp.Z * (float)(vector.Y * vector.Z * (1.0f - Math.Cos(angle)) - vector.X * Math.Sin(angle));

            newPosition.Z =
                temp.X * (float)(vector.X * vector.Z * (1.0f - Math.Cos(angle)) - vector.Y * Math.Sin(angle)) +
                temp.Y * (float)(vector.Y * vector.Z * (1.0f - Math.Cos(angle)) + vector.X * Math.Sin(angle)) +
                temp.Z * (float)(Math.Cos(angle) + Math.Pow(vector.Z, 2.0f) * (1.0f - Math.Cos(angle)));

            if (isEuler)
            {
                temp = newPosition;
            }
            else
            {
                temp = newPosition + pivot;
            }
            return temp;
        }

        public void translate(float x, float y, float z)
        {
            model *= Matrix4.CreateTranslation(x, y, z);
            objectCenter.X += x;
            objectCenter.Y += y;
            objectCenter.Z += z;

            foreach (var i in child)
            {
                i.translate(x, y, z);
            }
        }

        
        #endregion*/
    }
}