using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Spongebob
    {
        protected float positionX;
        protected float positionY;
        Balok balok1 = new Balok(new Vector3(1.0f, 0.9f, 0.4f));
        Balok balok2 = new Balok(new Vector3(1f, 1f, 1f));
        Balok balok3 = new Balok(new Vector3(0.7f, 0.4f, 0.2f));
        Lingkaran lingkaran1 = new Lingkaran(new Vector3(1, 1, 1));
        Lingkaran lingkaran2 = new Lingkaran(new Vector3(1, 1, 1));
        Tabung tabung1 = new Tabung(new Vector3(1, 1, 1));
        Tabung tabung2 = new Tabung(new Vector3(1, 1, 1));
        Tabung tabung3 = new Tabung(new Vector3(0.7f, 0.4f, 0.2f));
        Tabung tabung4 = new Tabung(new Vector3(0.7f, 0.4f, 0.2f));
        Tabung tabung5 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung6 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung7 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung8 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung9 = new Tabung(new Vector3(1f, 1f, 1f));
        Tabung tabung10 = new Tabung(new Vector3(1f, 1f, 1f));
        Balok balok4 = new Balok(new Vector3(1.0f, 0.9f, 0.4f));
        Balok balok5 = new Balok(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung11 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung12 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung13 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung14 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung15 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung16 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung17 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Tabung tabung18 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f));
        Balok balok6 = new Balok(new Vector3(0, 0, 0));
        Balok balok7 = new Balok(new Vector3(0, 0, 0));
        public Spongebob(float posX=0.0f, float posY=0.0f)
        {
            positionX = posX;
            positionY = posY;
        }

        public void load(int sizeX, int sizeY)
        {
            balok1.createCuboid(0, 0, 0, 2.5f, 2.5f, 1.5f);
            balok1.load(sizeX, sizeY);
            //balok1.rotate(90f, 'y');

            balok2.createCuboid(0, -1.4f, 0, 2.5f, 0.3f, 1.5f);
            balok2.load(sizeX, sizeY);

            balok3.createCuboid(0, -1.65f, 0, 2.5f, 0.3f, 1.5f);
            balok3.load(sizeX, sizeY);

            lingkaran1.createEllipsoid(0.4f, 0.5f, 1f, 0.4f, 0.4f, 0.4f);
            lingkaran1.load(sizeX, sizeY);
            //halfelipse1.rotate(0f, 'x');

            lingkaran2.createEllipsoid(-0.4f, 0.5f, 1f, 0.4f, 0.4f, 0.4f);
            lingkaran2.load(sizeX, sizeY);

            tabung1.createCone(-1.4f, -0.9f, 0, 0.075f, 0.225f, 0.4f, 10000);
            tabung1.load(sizeX, sizeY);

            tabung2.createCone(1.4f, -0.9f, 0, 0.075f, 0.225f, 0.4f, 10000);
            tabung2.load(sizeX, sizeY);

            tabung3.createCone(-0.7f, -2.2f, 0, 0.2f, 0.3f, 0.2f, 10000);
            tabung3.load(sizeX, sizeY);

            tabung4.createCone(0.7f, -2.2f, 0, 0.2f, 0.3f, 0.2f, 10000);
            tabung4.load(sizeX, sizeY);

            tabung5.createCone(-1.47f, -2f, 0, 0.05f, 0.05f, 1.2f, 10000);
            tabung5.load(sizeX, sizeY);

            tabung6.createCone(1.47f, -2f, 0, 0.05f, 0.05f, 1.2f, 10000);
            tabung6.load(sizeX, sizeY);

            tabung7.createCone(-0.7f, -2.5f, 0, 0.05f, 0.05f, 0.3f, 10000);
            tabung7.load(sizeX, sizeY);

            tabung8.createCone(0.7f, -2.5f, 0, 0.05f, 0.05f, 0.3f, 10000);
            tabung8.load(sizeX, sizeY);

            tabung9.createCone(-0.7f, -3.1f, 0, 0.05f, 0.05f, 0.6f, 10000);
            tabung9.load(sizeX, sizeY);

            tabung10.createCone(0.7f, -3.1f, 0, 0.05f, 0.05f, 0.6f, 10000);
            tabung10.load(sizeX, sizeY);

            balok4.createCuboid(-1.47f, -2.1f, 0, 0.25f, 0.2f, 0.05f);
            balok4.load(sizeX, sizeY);

            balok5.createCuboid(1.47f, -2.1f, 0, 0.25f, 0.2f, 0.05f);
            balok5.load(sizeX, sizeY);

            tabung11.createCone(1.56f, -2.4f, 0, 0.02f, 0.02f, 0.2f, 10000);
            tabung11.load(sizeX, sizeY);

            tabung12.createCone(1.49f, -2.4f, 0, 0.02f, 0.02f, 0.2f, 10000);
            tabung12.load(sizeX, sizeY);

            tabung13.createCone(1.42f, -2.4f, 0, 0.02f, 0.02f, 0.2f, 10000);
            tabung13.load(sizeX, sizeY);

            tabung14.createCone(1.35f, -2.3f, 0, 0.02f, 0.02f, 0.2f, 10000);
            tabung14.load(sizeX, sizeY);

            tabung15.createCone(-1.56f, -2.4f, 0, 0.02f, 0.02f, 0.2f, 10000);
            tabung15.load(sizeX, sizeY);

            tabung16.createCone(-1.49f, -2.4f, 0, 0.02f, 0.02f, 0.2f, 10000);
            tabung16.load(sizeX, sizeY);

            tabung17.createCone(-1.42f, -2.4f, 0, 0.02f, 0.02f, 0.2f, 10000);
            tabung17.load(sizeX, sizeY);

            tabung18.createCone(-1.35f, -2.3f, 0, 0.02f, 0.02f, 0.2f, 10000);
            tabung18.load(sizeX, sizeY);

            balok6.createCuboid(-0.7f, -3.1f, 0.15f, 0.25f, 0.2f, 0.6f);
            balok6.load(sizeX, sizeY);

            balok7.createCuboid(0.7f, -3.1f, 0.15f, 0.25f, 0.2f, 0.6f);
            balok7.load(sizeX, sizeY);
        }

        public void render(double time)
        {
            balok1.render(time);
            balok2.render(time);
            balok3.render(time);
            lingkaran1.render(time);
            lingkaran2.render(time);
            tabung1.render(time);
            tabung2.render(time);
            tabung3.render(time);
            tabung4.render(time);
            tabung5.render(time);
            tabung6.render(time);
            tabung7.render(time);
            tabung8.render(time);
            tabung9.render(time);
            tabung10.render(time);
            balok4.render(time);
            balok5.render(time);
            tabung11.render(time);
            tabung12.render(time);
            tabung13.render(time);
            tabung14.render(time);
            tabung15.render(time);
            tabung16.render(time);
            tabung17.render(time);
            tabung18.render(time);
            balok6.render(time);
            balok7.render(time);
        }

    }
}
