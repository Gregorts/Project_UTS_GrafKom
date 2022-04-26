using OpenTK.Mathematics;
using LearnOpenTK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Ground
    {
        protected float positionX, positionY, positionZ;

        protected Balok balok1;

        public Ground(float posX = 1f, float posY = 0.5f, float posZ = 0f)
        {
            this.positionX = posX;
            this.positionY = posY;
            this.positionZ = posZ;

            balok1 = new Balok(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
        }

        public void load(int sizeX, int sizeY)
        {
            balok1.createCube(positionX, positionY, positionZ, 30f, 2f, 10f);
            balok1.load(sizeX, sizeY);
        }

        public void render(Camera _camera)
        {
            balok1.CameraMovement(_camera);
            balok1.render();
        }

        public void scale(float m)
        {
            balok1.scale(m);
        }
    }
}
