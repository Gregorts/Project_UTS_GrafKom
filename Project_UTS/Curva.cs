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
        protected float[] _vertexBezier = new float[9];
        protected int _index;
        protected int[] _pascal;

        public Curva(Vector3 color, Vector3 pos) : base(color, pos)
        {
            this.color = color;
            this.posX = pos.X;
            this.posY = pos.Y;
            this.posZ = pos.Z;
        }

        public void AddPosition(float _x, float _y, float _z)
        {
            _vertexBezier[_index * 3] = _x;
            _vertexBezier[_index * 3 + 1] = _y;
            _vertexBezier[_index * 3 + 2] = _z;
            _index++;

            GL.BufferData(BufferTarget.ArrayBuffer, _vertexBezier.Length * sizeof(float), _vertexBezier, BufferUsageHint.StaticDraw);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
        }

        public List<int> getRow(int rowIndex)
        {
            List<int> currow = new List<int>();
            //------
            currow.Add(1);
            if (rowIndex == 0)
            {
                return currow;
            }
            //-----
            List<int> prev = getRow(rowIndex - 1);
            for (int i = 1; i < prev.Count; i++)
            {
                int curr = prev[i - 1] + prev[i];
                currow.Add(curr);
            }
            currow.Add(1);
            return currow;
        }

        public void createCurveBezier()
        {
            List<int> pascal = getRow(_index - 1);

            _pascal = pascal.ToArray();
            for (float t = 0; t <= 1.0f; t += 0.01f)
            {
                Vector3 p = getP(_index, t);
                vertices.Add(p);
            }
        }

        public Vector3 getP(int n, float t)
        {
            Vector3 p = new Vector3(0, 0, 0);
            float k;
            for (int i = 0; i < n; i++)
            {
                k = (float)Math.Pow((1 - t), n - 1 - i) * (float)Math.Pow(t, i) * _pascal[i];
                p.X += k * _vertexBezier[i * 3];
                p.Y += k * _vertexBezier[i * 3 + 1];
                p.Z += k * _vertexBezier[i * 3 + 2];
            }
            return p;
        }
    }
}
