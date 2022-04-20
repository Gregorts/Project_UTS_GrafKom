using OpenTK.Mathematics;
using LearnOpenTK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Spongebob
    {
        protected float positionX, positionY, positionZ;

        protected Balok balok1, balok2, balok3, balok4, balok5, balok6, balok7;
        protected Lingkaran lingkaran1, lingkaran2, lingkaran3, lingkaran4, lingkaran5, lingkaran6;
        protected Tabung tabung1, tabung2, tabung3, tabung4, tabung5, tabung6, tabung7, tabung8, tabung9, tabung10, tabung11, tabung12, tabung13, tabung14, tabung15, tabung16, tabung17, tabung18;

        public Spongebob(float posX = 0f, float posY = 0f, float posZ = 0f)
        {
            positionX = posX;
            positionY = posY;
            positionZ = posZ;

            balok1 = new Balok(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            balok2 = new Balok(new Vector3(1f, 1f, 1f), new Vector3(positionX, positionY, positionZ));
            balok3 = new Balok(new Vector3(0.7f, 0.4f, 0.2f), new Vector3(positionX, positionY, positionZ));
            lingkaran1 = new Lingkaran(new Vector3(1, 1, 1), new Vector3(positionX, positionY, positionZ));
            lingkaran2 = new Lingkaran(new Vector3(1, 1, 1), new Vector3(positionX, positionY, positionZ));
            tabung1 = new Tabung(new Vector3(1, 1, 1), new Vector3(positionX, positionY, positionZ));
            tabung2 = new Tabung(new Vector3(1, 1, 1), new Vector3(positionX, positionY, positionZ));
            tabung3 = new Tabung(new Vector3(0.7f, 0.4f, 0.2f), new Vector3(positionX, positionY, positionZ));
            tabung4 = new Tabung(new Vector3(0.7f, 0.4f, 0.2f), new Vector3(positionX, positionY, positionZ));
            tabung5 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung6 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung7 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung8 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung9 = new Tabung(new Vector3(1f, 1f, 1f), new Vector3(positionX, positionY, positionZ));
            tabung10 = new Tabung(new Vector3(1f, 1f, 1f), new Vector3(positionX, positionY, positionZ));
            balok4 = new Balok(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            balok5 = new Balok(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung11 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung12 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung13 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung14 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung15 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung16 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung17 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            tabung18 = new Tabung(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            balok6 = new Balok(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            balok7 = new Balok(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            lingkaran3 = new Lingkaran(new Vector3(0.15f, 0.72f, 0.78f), new Vector3(positionX, positionY, positionZ));
            lingkaran4 = new Lingkaran(new Vector3(0.15f, 0.72f, 0.78f), new Vector3(positionX, positionY, positionZ));
            lingkaran5 = new Lingkaran(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            lingkaran6 = new Lingkaran(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
        }

        public void load(int sizeX, int sizeY)
        {
            balok1.createCube(positionX, positionY, positionZ, 2.5f, 2.5f, 1.5f);
            balok1.load(sizeX, sizeY);

            balok2.createCube(balok1.getPos().X, balok1.getPos().Y - balok1.getleny() / 2, balok1.getPos().Z, balok1.getlenx(), balok1.getleny() / 8, balok1.getlenz());
            balok2.load(sizeX, sizeY);

            balok3.createCube(balok2.getPos().X, balok2.getPos().Y - balok2.getleny() / 2, balok2.getPos().Z, balok2.getlenx(), balok2.getleny(), balok2.getlenz());
            balok3.load(sizeX, sizeY);

            lingkaran1.createSphere(balok1.getPos().X + balok1.getlenx() / 6, balok1.getPos().Y + balok1.getleny() / 5, balok1.getPos().Z + balok1.getlenz() / 2, balok1.getlenx() / 6, balok1.getleny() / 6, balok1.getlenz() / 7, 1000, 1000);
            lingkaran1.load(sizeX, sizeY);

            lingkaran2.createSphere(balok1.getPos().X - balok1.getlenx() / 6, balok1.getPos().Y + balok1.getleny() / 5, balok1.getPos().Z + balok1.getlenz() / 2, balok1.getlenx() / 6, balok1.getleny() / 6, balok1.getlenz() / 7, 1000, 1000);
            lingkaran2.load(sizeX, sizeY);

            tabung1.createTube(balok1.getPos().X - balok1.getlenx() / 1.85f, balok1.getPos().Y - balok1.getleny() / 3, balok1.getPos().Z, 100, balok1.getlenx() / 10, balok1.getleny() / 6); //ini
            tabung1.load(sizeX, sizeY);

            tabung2.createTube(balok1.getPos().X + balok1.getlenx() / 1.85f, balok1.getPos().Y - balok1.getleny() / 3, balok1.getPos().Z, 100, balok1.getlenx() / 10, balok1.getleny() / 6); //ini
            tabung2.load(sizeX, sizeY);

            tabung3.createTube(balok3.getPos().X - balok3.getlenx() / 3.5f, balok3.getPos().Y - balok3.getleny() * 1.5f, balok3.getPos().Z, 100, balok3.getlenx() / 8, balok3.getleny()); //ini
            tabung3.load(sizeX, sizeY);
            
            tabung4.createTube(balok3.getPos().X + balok3.getlenx() / 3.5f, balok3.getPos().Y - balok3.getleny() * 1.5f, balok3.getPos().Z, 100, balok3.getlenx() / 8, balok3.getleny()); //ini
            tabung4.load(sizeX, sizeY);

            tabung5.createTube(tabung1.getPos().X - tabung1.getrad() * 1.5f, tabung1.getPos().Y - tabung1.getheight() * 3.5f, tabung1.getPos().Z, 100, 0.05f, 1.2f);
            tabung5.load(sizeX, sizeY);
            Console.WriteLine(balok1.getPos().X - balok1.getlenx() / 1.85f);

            tabung6.createTube(positionX + 1.47f, positionY - 2f, 0, 100, 0.05f, 1.2f);
            tabung6.load(sizeX, sizeY);

            tabung7.createTube(positionX - 0.7f, positionY - 2.5f, 0, 100, 0.05f, 0.3f);
            tabung7.load(sizeX, sizeY);

            tabung8.createTube(positionX + 0.7f, positionY - 2.5f, 0, 100, 0.05f, 0.3f);
            tabung8.load(sizeX, sizeY);

            tabung9.createTube(positionX - 0.7f, positionY - 3.1f, 0, 100, 0.05f, 0.6f);
            tabung9.load(sizeX, sizeY);

            tabung10.createTube(positionX + 0.7f, positionY - 3.1f, 0, 100, 0.05f, 0.6f);
            tabung10.load(sizeX, sizeY);

            balok4.createCube(positionX - 1.47f, positionY - 2.1f, 0, 0.25f, 0.2f, 0.05f);
            balok4.load(sizeX, sizeY);

            balok5.createCube(positionX + 1.47f, positionY - 2.1f, 0, 0.25f, 0.2f, 0.05f);
            balok5.load(sizeX, sizeY);

            tabung11.createTube(positionX + 1.56f, positionY - 2.4f, 0, 100, 0.02f, 0.2f);
            tabung11.load(sizeX, sizeY);

            tabung12.createTube(positionX + 1.49f, positionY - 2.4f, 0, 100, 0.02f, 0.2f);
            tabung12.load(sizeX, sizeY);

            tabung13.createTube(positionX + 1.42f, positionY - 2.4f, 0, 100, 0.02f, 0.2f);
            tabung13.load(sizeX, sizeY);

            tabung14.createTube(positionX + 1.35f, positionY - 2.3f, 0, 100, 0.02f, 0.2f);
            tabung14.load(sizeX, sizeY);

            tabung15.createTube(positionX - 1.56f, positionY - 2.4f, 0, 100, 0.02f, 0.2f);
            tabung15.load(sizeX, sizeY);

            tabung16.createTube(positionX - 1.49f, positionY - 2.4f, 0, 100, 0.02f, 0.2f);
            tabung16.load(sizeX, sizeY);

            tabung17.createTube(positionX - 1.42f, positionY - 2.4f, 0, 100, 0.02f, 0.2f);
            tabung17.load(sizeX, sizeY);

            tabung18.createTube(positionX - 1.35f, positionY - 2.3f, 0, 100, 0.02f, 0.2f);
            tabung18.load(sizeX, sizeY);

            balok6.createCube(positionX - 0.7f, positionY - 3.1f, 0.15f, 0.25f, 0.2f, 0.6f);
            balok6.load(sizeX, sizeY);

            balok7.createCube(positionX + 0.7f, positionY - 3.1f, 0.15f, 0.25f, 0.2f, 0.6f);
            balok7.load(sizeX, sizeY);

            lingkaran3.createSphere(positionX + 0.4f, positionY + 0.5f, 0.85f, 0.15f, 0.15f, 0.1f, 1000, 1000);
            lingkaran3.load(sizeX, sizeY);

            lingkaran4.createSphere(positionX - 0.4f, positionY + 0.5f, 0.85f, 0.15f, 0.15f, 0.1f, 1000, 1000);
            lingkaran4.load(sizeX, sizeY);

            lingkaran5.createSphere(positionX + 0.4f, positionY + 0.5f, 0.92f, 0.05f, 0.05f, 0.05f, 1000, 1000);
            lingkaran5.load(sizeX, sizeY);

            lingkaran6.createSphere(positionX - 0.4f, positionY + 0.5f, 0.92f, 0.05f, 0.05f, 0.05f, 1000, 1000);
            lingkaran6.load(sizeX, sizeY);
        }

        public void render(Camera _camera, double time)
        {
            balok1.CameraMovement(_camera);
            balok1.render(time);

            balok2.CameraMovement(_camera);
            balok2.render(time);

            balok3.CameraMovement(_camera);
            balok3.render(time);

            lingkaran1.CameraMovement(_camera);
            lingkaran1.render(time);

            lingkaran2.CameraMovement(_camera);
            lingkaran2.render(time);

            tabung1.CameraMovement(_camera);
            tabung1.render(time);

            tabung2.CameraMovement(_camera);
            tabung2.render(time);

            tabung3.CameraMovement(_camera);
            tabung3.render(time);

            tabung4.CameraMovement(_camera);
            tabung4.render(time);

            tabung5.CameraMovement(_camera);
            tabung5.render(time);

            //tabung6.CameraMovement(_camera);
            //tabung6.render(time);

            //tabung7.CameraMovement(_camera);
            //tabung7.render(time);

            //tabung8.CameraMovement(_camera);
            //tabung8.render(time);

            //tabung9.CameraMovement(_camera);
            //tabung9.render(time);

            //tabung10.CameraMovement(_camera);
            //tabung10.render(time);

            //balok4.CameraMovement(_camera);
            //balok4.render(time);

            //balok5.CameraMovement(_camera);
            //balok5.render(time);

            //tabung11.CameraMovement(_camera);
            //tabung11.render(time);

            //tabung12.CameraMovement(_camera);
            //tabung12.render(time);

            //tabung13.CameraMovement(_camera);
            //tabung13.render(time);

            //tabung14.CameraMovement(_camera);
            //tabung14.render(time);

            //tabung15.CameraMovement(_camera);
            //tabung15.render(time);

            //tabung16.CameraMovement(_camera);
            //tabung16.render(time);

            //tabung17.CameraMovement(_camera);
            //tabung17.render(time);

            //tabung18.CameraMovement(_camera);
            //tabung18.render(time);

            //balok6.CameraMovement(_camera);
            //balok6.render(time);

            //balok7.CameraMovement(_camera);
            //balok7.render(time);

            //lingkaran3.CameraMovement(_camera);
            //lingkaran3.render(time);

            //lingkaran4.CameraMovement(_camera);
            //lingkaran4.render(time);

            //lingkaran5.CameraMovement(_camera);
            //lingkaran5.render(time);

            //lingkaran6.CameraMovement(_camera);
            //lingkaran6.render(time);
        }

    }
}
