using LearnOpenTK.Common;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Asset2d
    {
        /*int indexs;
        int[] _pascal;
        Shader _shader;

        public Asset2d()
        {
            indexs = 0;
        }
        public List<int> GetRow(int rowIndex)
        {
            List<int> currow = new List<int>();
            //------
            currow.Add(1);
            if (rowIndex == 0)
            {
                return currow;
            }
            //-----
            List<int> prev = GetRow(rowIndex - 1);
            for (int i = 1; i < prev.Count; i++)
            {
                int curr = prev[i - 1] + prev[i];
                currow.Add(curr);
            }
            currow.Add(1);
            return currow;
        }

        public List<float> CreateCurveBezier()
        {
            List<float> _vertices_bezier = new List<float>();

            List<int> pascal = GetRow(indexs - 1);
            _pascal = pascal.ToArray();
            for (float t = 0; t <= 1.0f; t += 0.01f)
            {
                Vector2 p = GetP(indexs, t);
                _vertices_bezier.Add(p.X);
                _vertices_bezier.Add(p.Y);
                _vertices_bezier.Add(0);
            }
            return _vertices_bezier;
        }

        public Vector2 GetP(int n, float t)
        {
            Vector2 p = new Vector2(0, 0);
            float k;
            for (int i = 0; i < n; i++)
            {
                k = (float)Math.Pow((1 - t), n - 1 - i) * (float)Math.Pow(t, i) * _pascal[i];
                p.X += k * _vertices[i * 3];
                p.Y += k * _vertices[i * 3 + 1];
            }
            return p;
        }*/
    }
}
