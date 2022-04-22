using LearnOpenTK.Common;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Plankton
    {
        protected float positionX, positionY, positionZ;

        // badan
        protected Lingkaran badan;

        // mata
        protected Lingkaran mata, kornea;

        // kaki
        protected Tabung kt1, kt2; 
        protected Lingkaran ko1, ko2;

        // tangan

        // antena

        public Plankton(float posX = 0f, float posY = 0f, float posZ = 0f)
        {
            positionX = posX;
            positionY = posY;
            positionZ = posZ;

            badan = new Lingkaran(new Vector3(0f, 0.28f, 0.23f), new Vector3(positionX, positionY, positionZ));
            mata = new Lingkaran(new Vector3(1f, 1f, 1f), new Vector3(positionX, positionY, positionZ));
            kornea = new Lingkaran(new Vector3(0f, 0f, 0f), new Vector3(positionX, positionY, positionZ));
            kt1 = new Tabung(new Vector3(0f, 0.28f, 0.23f), new Vector3(positionX, positionY, positionZ));
            kt2 = new Tabung(new Vector3(0f, 0.28f, 0.23f), new Vector3(positionX, positionY, positionZ));
            ko1 = new Lingkaran(new Vector3(0f, 0.28f, 0.23f), new Vector3(positionX, positionY, positionZ));
            ko2 = new Lingkaran(new Vector3(0f, 0.28f, 0.23f), new Vector3(positionX, positionY, positionZ));
        }

        public void load(int sizeX, int sizeY)
        {
            badan.createSphere(positionX, positionY, positionZ, 1.5f, 2.5f, 2.5f, 1000, 1000);
            badan.load(sizeX, sizeY);
        }

        public void render(Camera _camera, double time)
        {
            badan.CameraMovement(_camera);
            badan.render(time);
        }
    }
}
