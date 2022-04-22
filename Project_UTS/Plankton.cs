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

        protected Kerucut kaki1, kaki2;

        // tangan
        protected Kerucut tangan1, tangan2;

        // antena
        protected Balok antena1, antena2;

        // alis
        protected Balok alis;

        public Plankton(float posX = 0f, float posY = 0f, float posZ = 0f)
        {
            positionX = posX;
            positionY = posY;
            positionZ = posZ;

            badan = new Lingkaran(new Vector3(0.25f, 0.51f, 0.42f), new Vector3(positionX, positionY, positionZ));
            mata = new Lingkaran(new Vector3(0.89f, 0.87f, 0.6f), new Vector3(positionX, positionY, positionZ));
            kornea = new Lingkaran(new Vector3(0.69f, 0.28f, 0.28f), new Vector3(positionX, positionY, positionZ));

            kaki1 = new Kerucut(new Vector3(0.25f, 0.51f, 0.42f), new Vector3(positionX, positionY, positionZ));
            kaki2 = new Kerucut(new Vector3(0.25f, 0.51f, 0.42f), new Vector3(positionX, positionY, positionZ));

            tangan1 = new Kerucut(new Vector3(0.25f, 0.51f, 0.42f), new Vector3(positionX, positionY, positionZ));
            tangan2 = new Kerucut(new Vector3(0.25f, 0.51f, 0.42f), new Vector3(positionX, positionY, positionZ));

            antena1 = new Balok(new Vector3(0.25f, 0.51f, 0.42f), new Vector3(positionX, positionY, positionZ));
            antena2 = new Balok(new Vector3(0.25f, 0.51f, 0.42f), new Vector3(positionX, positionY, positionZ));

            alis = new Balok(new Vector3(0f, 0f, 0f), new Vector3(positionX, positionY, positionZ));
        }

        public void load(int sizeX, int sizeY)
        {
            badan.createSphere(positionX, positionY, positionZ, 1f, 2f, 1f, 1000, 1000);
            badan.load(sizeX, sizeY);

            mata.createSphere(badan.getPos().X, badan.getPos().Y + badan.getrady() * 1.25f, badan.getPos().Z + badan.getradz() / 1.75f, badan.getradx() / 2.5f, badan.getrady() / 4f, badan.getradz() / 2f, 1000, 1000);
            mata.load(sizeX, sizeY);
            Console.WriteLine(mata.getPos().X);

            kornea.createSphere(mata.getPos().X, mata.getPos().Y + mata.getrady() * 2.1f, mata.getPos().Z + mata.getradz() * 2, mata.getradx() / 3f, mata.getrady() / 3f, mata.getradz() / 3f, 1000, 1000);
            kornea.load(sizeX, sizeY);

            kaki1.createCone(badan.getPos().X + badan.getradx() / 2, badan.getPos().Y + badan.getrady() * 1.65f, badan.getPos().Z, badan.getradx() / 5, badan.getrady() / 2, 10000);
            kaki1.load(sizeX, sizeY);
            kaki1.rotate(180, 'z');

            kaki2.createCone(badan.getPos().X - badan.getradx() / 2, badan.getPos().Y + badan.getrady() * 1.65f, badan.getPos().Z, badan.getradx() / 5, badan.getrady() / 2, 10000);
            kaki2.load(sizeX, sizeY);
            kaki2.rotate(180, 'z');

            tangan1.createCone(badan.getPos().X - badan.getradx(), badan.getPos().Y + badan.getrady(), badan.getPos().Z, badan.getradx() / 5, badan.getrady() * 0.75f, 10000);
            tangan1.load(sizeX, sizeY);
            tangan1.rotate(45, 'z');

            tangan2.createCone(badan.getPos().X + badan.getradx(), badan.getPos().Y + badan.getrady(), badan.getPos().Z, badan.getradx() / 5, badan.getrady() * 0.75f, 10000);
            tangan2.load(sizeX, sizeY);
            tangan2.rotate(-45, 'z');

            antena1.createCube(badan.getPos().X - badan.getradx() / 2, badan.getPos().Y + badan.getrady() * 2f, badan.getPos().Z, badan.getradx() / 10, badan.getrady() * 0.75f, badan.getradz() / 10);
            antena1.load(sizeX, sizeY);
            antena1.rotate(30, 'z');

            antena2.createCube(badan.getPos().X + badan.getradx() / 2, badan.getPos().Y + badan.getrady() * 2f, badan.getPos().Z, badan.getradx() / 10, badan.getrady() * 0.75f, badan.getradz() / 10);
            antena2.load(sizeX, sizeY);
            antena2.rotate(-30, 'z');

            alis.createCube(mata.getPos().X, mata.getPos().Y + mata.getrady() * 2.75f, mata.getPos().Z + mata.getrady() * 1.75f, mata.getradx() * 1.75f, mata.getrady() / 4, mata.getradz() / 2);
            alis.load(sizeX, sizeY);
        }

        public void render(Camera _camera, double time)
        {
            badan.CameraMovement(_camera);
            badan.render(time);

            mata.CameraMovement(_camera);
            mata.render(time);

            kornea.CameraMovement(_camera);
            kornea.render(time);

            kaki1.CameraMovement(_camera);
            kaki1.render(time);

            kaki2.CameraMovement(_camera);
            kaki2.render(time);

            tangan1.CameraMovement(_camera);
            tangan1.render(time);

            tangan2.CameraMovement(_camera);
            tangan2.render(time);

            antena1.CameraMovement(_camera);
            antena1.render(time);

            antena2.CameraMovement(_camera);
            antena2.render(time);

            alis.CameraMovement(_camera);
            alis.render(time);
        }
    }
}
