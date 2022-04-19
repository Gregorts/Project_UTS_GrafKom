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
        protected float positionX;
        protected float positionY;
        Tabung cone1 = new Tabung(new Vector3(0.92f, 0.69f, 0.69f));
        Lingkaran halflingkaran1 = new Lingkaran(new Vector3(0.59f, 0.87f, 0.41f));
        Lingkaran lingkaran1 = new Lingkaran(new Vector3(1, 1, 1));
        Lingkaran lingkaran2 = new Lingkaran(new Vector3(1, 1, 1));
        Tabung cone2 = new Tabung(new Vector3(0.92f, 0.69f, 0.69f));
        Tabung cone3 = new Tabung(new Vector3(0.92f, 0.69f, 0.69f));
        Tabung tabung1 = new Tabung(new Vector3(0.59f, 0.87f, 0.41f));
        Tabung tabung2 = new Tabung(new Vector3(0.59f, 0.87f, 0.41f));
        Tabung cone4 = new Tabung(new Vector3(0.92f, 0.69f, 0.69f));
        Tabung cone5 = new Tabung(new Vector3(0.92f, 0.69f, 0.69f));

        public Patrick(float posX = 0.0f, float posY = 0.0f)
        {
            positionX = posX;
            positionY = posY;
        }

        public void load(int sizeX, int sizeY)
        {
            cone1.createCone(0f, -1f, 0, 0.1f, 1.5f, 4f, 10000);
            cone1.load(sizeX, sizeY);

            halflingkaran1.createHalfEllipsoid(0, -0.8f, 0, 1.5f, 1.5f, 1.5f);
            halflingkaran1.load(sizeX, sizeY);

            lingkaran1.createEllipsoid(0.2f, 1f, 1f, 0.2f, 0.3f, 0.2f);
            lingkaran1.load(sizeX, sizeY);

            lingkaran2.createEllipsoid(-0.2f, 1f, 1f, 0.2f, 0.3f, 0.2f);
            lingkaran2.load(sizeX, sizeY);

            cone2.createCone(-0.8f, 0.6f, 0, 0.05f, 0.5f, 1.5f, 10000);
            cone2.load(sizeX, sizeY);
            cone2.rotate(45, 'z');

            cone3.createCone(0.8f, 0.6f, 0, 0.05f, 0.5f, 1.5f, 10000);
            cone3.load(sizeX, sizeY);
            cone3.rotate(-45, 'z');

            tabung1.createCone(-0.8f, -2.5f, 0, 0.5f, 0.5f, 1f, 10000);
            tabung1.load(sizeX, sizeY);

            tabung2.createCone(0.8f, -2.5f, 0, 0.5f, 0.5f, 1f, 10000);
            tabung2.load(sizeX, sizeY);

            cone4.createCone(-0.8f, -3f, 0, 0.45f, 0.1f, 0.6f, 10000);
            cone4.load(sizeX, sizeY);

            cone5.createCone(0.8f, -3f, 0, 0.45f, 0.1f, 0.6f, 10000);
            cone5.load(sizeX, sizeY);
        }

        public void render(double time)
        {
            cone1.render(time);
            halflingkaran1.render(time);
            lingkaran1.render(time);
            lingkaran2.render(time);
            cone2.render(time);
            cone3.render(time);
            tabung1.render(time);
            tabung2.render(time);
            cone4.render(time);
            cone5.render(time);
        }
    }
}
