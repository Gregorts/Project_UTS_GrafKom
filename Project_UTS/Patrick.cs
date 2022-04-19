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

        Kerucut cone1 = new Kerucut(new Vector3(0.92f, 0.69f, 0.69f));
        Lingkaran halflingkaran1 = new Lingkaran(new Vector3(0.59f, 0.87f, 0.41f));
        Lingkaran lingkaran1 = new Lingkaran(new Vector3(1, 1, 1));
        Lingkaran lingkaran2 = new Lingkaran(new Vector3(1, 1, 1));
        Kerucut cone2 = new Kerucut(new Vector3(0.92f, 0.69f, 0.69f));
        Kerucut cone3 = new Kerucut(new Vector3(0.92f, 0.69f, 0.69f));
        Tabung tabung1 = new Tabung(new Vector3(0.59f, 0.87f, 0.41f));
        Tabung tabung2 = new Tabung(new Vector3(0.59f, 0.87f, 0.41f));
        Kerucut cone4 = new Kerucut(new Vector3(0.92f, 0.69f, 0.69f));
        Kerucut cone5 = new Kerucut(new Vector3(0.92f, 0.69f, 0.69f));

        public Patrick(float posX = 0.5f, float posY = -1f)
        {
            positionX = posX;
            positionY = posY;
        }

        public void load(int sizeX, int sizeY)
        {
            cone1.createCone(positionX, positionY, 0, 1.5f, 4f, 10000);
            cone1.load(sizeX, sizeY);

            halflingkaran1.createHalfSphere(positionX * -1, (positionY * -1f), 0, 1.5f, 1.5f, 1.5f, 1000, 1000);
            halflingkaran1.load(sizeX, sizeY);
            halflingkaran1.rotate(180, 'z');

            //lingkaran1.createEllipsoid(0.2f, 1f, 1f, 0.2f, 0.3f, 0.2f);
            lingkaran1.createSphere(positionX + 0.2f, positionY + 2f, 0.8f, 0.2f, 0.3f, 0.2f, 1000, 1000);
            lingkaran1.load(sizeX, sizeY);

            lingkaran2.createSphere(positionX - 0.2f, positionY + 2f, 0.8f, 0.2f, 0.3f, 0.2f, 1000, 1000);
            lingkaran2.load(sizeX, sizeY);

            cone2.createCone(positionX * -2, (positionY * 1f), 0, 0.5f, 1.5f, 10000);
            cone2.load(sizeX, sizeY);
            cone2.rotate(90, 'z');

            cone3.createCone(-0.7f, 0.6f, 0, 0.5f, 1.5f, 10000);
            cone3.load(sizeX, sizeY);
            cone3.rotate(-45, 'z');

            tabung1.createTube(positionX - 0.8f, positionY - 1.6f, 0, 100, 0.5f, 1f);
            tabung1.load(sizeX, sizeY);

            tabung2.createTube(positionX + 0.8f, positionY - 1.6f, 0, 100, 0.5f, 1f);
            tabung2.load(sizeX, sizeY);

            cone4.createCone((positionX - 0.8f) * -1, (positionY * -1f) + 1.6f, 0, 0.4f, 0.6f, 10000);
            cone4.load(sizeX, sizeY);
            cone4.rotate(180, 'z');

            cone5.createCone((positionX + 0.8f) * -1, (positionY * -1f) + 1.6f, 0, 0.4f, 0.6f, 10000);
            cone5.load(sizeX, sizeY);
            cone5.rotate(180, 'z');
        }

        public void render(double time)
        {
            cone1.render(time);
            halflingkaran1.render(time);
            lingkaran1.render(time);
            lingkaran2.render(time);
            cone2.render(time);
            //cone3.render(time);
            /*tabung1.render(time);
            tabung2.render(time);
            cone4.render(time);
            cone5.render(time);*/
        }
    }
}
