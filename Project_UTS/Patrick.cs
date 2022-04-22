﻿using LearnOpenTK.Common;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Patrick
    {
        protected float positionX, positionY, positionZ;

        protected Kerucut cone1, cone2, cone3, cone4, cone5;
        protected Lingkaran lingkaran1, lingkaran2, lingkaran3, lingkaran4;
        protected Lingkaran halflingkaran1;
        protected Tabung tabung1, tabung2;

        public Patrick(float posX = 0f, float posY = -0.5f, float posZ = 0f)
        {
            positionX = posX;
            positionY = posY;
            positionZ = posZ;

            cone1 = new Kerucut(new Vector3(0.92f, 0.69f, 0.69f), new Vector3(positionX, positionY, positionZ));
            halflingkaran1 = new Lingkaran(new Vector3(0.59f, 0.87f, 0.41f), new Vector3(positionX, positionY, positionZ));
            lingkaran1 = new Lingkaran(new Vector3(1, 1, 1), new Vector3(positionX, positionY, positionZ));
            lingkaran2 = new Lingkaran(new Vector3(1, 1, 1), new Vector3(positionX, positionY, positionZ));
            cone2 = new Kerucut(new Vector3(0.92f, 0.69f, 0.69f), new Vector3(positionX, positionY, positionZ));
            cone3 = new Kerucut(new Vector3(0.92f, 0.69f, 0.69f), new Vector3(positionX, positionY, positionZ));
            tabung1 = new Tabung(new Vector3(0.59f, 0.87f, 0.41f), new Vector3(positionX, positionY, positionZ));
            tabung2 = new Tabung(new Vector3(0.59f, 0.87f, 0.41f), new Vector3(positionX, positionY, positionZ));
            cone4 = new Kerucut(new Vector3(0.92f, 0.69f, 0.69f), new Vector3(positionX, positionY, positionZ));
            cone5 = new Kerucut(new Vector3(0.92f, 0.69f, 0.69f), new Vector3(positionX, positionY, positionZ));
            lingkaran3 = new Lingkaran(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            lingkaran4 = new Lingkaran(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
        }

        public void load(int sizeX, int sizeY)
        {
            cone1.createCone(positionX, positionY, positionZ, 1.5f, 4f, 10000);
            cone1.load(sizeX, sizeY);

            halflingkaran1.createHalfSphere(cone1.getPos().X * cone1.getheight() / -cone1.getheight(), cone1.getPos().Y * cone1.getheight() / -cone1.getheight(), cone1.getPos().Z, cone1.getrad(), cone1.getrad(), cone1.getrad(), 1000, 1000);
            halflingkaran1.load(sizeX, sizeY);
            halflingkaran1.rotate(180, 'z');

            lingkaran1.createSphere(cone1.getPos().X + cone1.getrad() * 0.15f, cone1.getPos().Y + cone1.getheight() / 2, cone1.getPos().Z + cone1.getrad() / 2.5f, cone1.getrad() / 6, cone1.getrad() / 5, cone1.getrad() / 6, 1000, 1000);
            lingkaran1.load(sizeX, sizeY);

            lingkaran2.createSphere(cone1.getPos().X - cone1.getrad() * 0.15f, cone1.getPos().Y + cone1.getheight() / 2, cone1.getPos().Z + cone1.getrad() / 2.5f, cone1.getrad() / 6, cone1.getrad() / 5, cone1.getrad() / 6, 1000, 1000);
            lingkaran2.load(sizeX, sizeY);

            cone2.createCone(cone1.getPos().X, cone1.getPos().Y + cone1.getheight() / 4, cone1.getPos().Z, cone1.getrad() / 3, cone1.getheight() / 2.5f, 10000);
            cone2.load(sizeX, sizeY);
            cone2.rotate(45, 'z');

            cone3.createCone(cone1.getPos().X, cone1.getPos().Y + cone1.getheight() / 4, cone1.getPos().Z, cone1.getrad() / 3, cone1.getheight() / 2.5f, 10000);
            cone3.load(sizeX, sizeY);
            cone3.rotate(-45, 'z');

            tabung1.createTube(halflingkaran1.getPos().X - halflingkaran1.getradx() / 2f, halflingkaran1.getPos().Y - halflingkaran1.getrady() * 1.5f, cone1.getPos().Z, 100, halflingkaran1.getradx() / 3, halflingkaran1.getrady() / 1.5f);
            tabung1.load(sizeX, sizeY);
            
            tabung2.createTube(halflingkaran1.getPos().X + halflingkaran1.getradx() / 2f, halflingkaran1.getPos().Y - halflingkaran1.getrady() * 1.5f, cone1.getPos().Z, 100, halflingkaran1.getradx() / 3, halflingkaran1.getrady() / 1.5f);
            tabung2.load(sizeX, sizeY);

            cone4.createCone(tabung1.getPos().X + tabung1.getrad() * 2, tabung1.getPos().Y + tabung1.getheight() * 2.5f, tabung1.getPos().Z, tabung1.getrad()/1.5f, tabung1.getheight(), 10000);
            cone4.load(sizeX, sizeY);
            cone4.rotate(180, 'z');

            cone5.createCone(tabung2.getPos().X - tabung2.getrad() * 4, tabung2.getPos().Y + tabung2.getheight() * 2.5f, tabung2.getPos().Z, tabung2.getrad() / 1.5f, tabung2.getheight(), 10000);
            cone5.load(sizeX, sizeY);
            cone5.rotate(180, 'z');

            lingkaran3.createSphere(lingkaran1.getPos().X + lingkaran1.getradx() / 1.1f, lingkaran1.getPos().Y + lingkaran1.getrady() * 6f, lingkaran1.getPos().Z + lingkaran1.getradz() * 3.3f, lingkaran1.getradx() / 3, lingkaran1.getrady() / 4, lingkaran1.getradz() / 5, 1000, 1000);
            lingkaran3.load(sizeX, sizeY);

            lingkaran4.createSphere(lingkaran2.getPos().X - lingkaran2.getradx() / 1.1f, lingkaran1.getPos().Y + lingkaran1.getrady() * 6f, lingkaran1.getPos().Z + lingkaran1.getradz() * 3.3f, lingkaran2.getradx() / 3, lingkaran2.getrady() / 4, lingkaran2.getradz() / 5, 1000, 1000);
            lingkaran4.load(sizeX, sizeY);
        }

        public void render(Camera _camera)
        {
            cone1.CameraMovement(_camera);
            cone1.render();

            halflingkaran1.CameraMovement(_camera);
            halflingkaran1.render();

            lingkaran1.CameraMovement(_camera);
            lingkaran1.render();

            lingkaran2.CameraMovement(_camera);
            lingkaran2.render();

            cone2.CameraMovement(_camera);
            cone2.render();

            cone3.CameraMovement(_camera);
            cone3.render();

            tabung1.CameraMovement(_camera);
            tabung1.render();

            tabung2.CameraMovement(_camera);
            tabung2.render();

            cone4.CameraMovement(_camera);
            cone4.render();

            cone5.CameraMovement(_camera);
            cone5.render();

            lingkaran3.CameraMovement(_camera);
            lingkaran3.render();

            lingkaran4.CameraMovement(_camera);
            lingkaran4.render();
        }

        public void scale(float m)
        {
            cone1.scale(m);
            halflingkaran1.scale(m);
            lingkaran1.scale(m);
            lingkaran2.scale(m);
            cone2.scale(m);
            cone3.scale(m);
            tabung1.scale(m);
            tabung2.scale(m);
            cone4.scale(m);
            cone5.scale(m);
            lingkaran3.scale(m);
            lingkaran4.scale(m);
        }
    }
}
