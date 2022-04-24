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

        protected Balok balok1, balok2, balok3, balok4, balok5, balok6, balok7, balok8, balok9, balok10, balok11, balok12, balok13;
        protected Lingkaran lingkaran1, lingkaran2, lingkaran3, lingkaran4, lingkaran5, lingkaran6;
        protected Lingkaran oval1, oval2, oval3, oval4, oval5, oval6, oval7, oval8, oval9;
        protected Tabung tabung1, tabung2, tabung3, tabung4, tabung5, tabung6, tabung7, tabung8, tabung9, tabung10;
        protected Curva curva;

        //int animate_number;
        //float angle = 0;
        //float counter = 0;

        public Spongebob(float posX = 1f, float posY = 0.5f, float posZ = 0f)
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
            oval1 = new Lingkaran(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            oval2 = new Lingkaran(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            oval3 = new Lingkaran(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            oval4 = new Lingkaran(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            oval5 = new Lingkaran(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            oval6 = new Lingkaran(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            oval7 = new Lingkaran(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            oval8 = new Lingkaran(new Vector3(1.0f, 0.9f, 0.4f), new Vector3(positionX, positionY, positionZ));
            balok6 = new Balok(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            balok7 = new Balok(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            lingkaran3 = new Lingkaran(new Vector3(0.15f, 0.72f, 0.78f), new Vector3(positionX, positionY, positionZ));
            lingkaran4 = new Lingkaran(new Vector3(0.15f, 0.72f, 0.78f), new Vector3(positionX, positionY, positionZ));
            lingkaran5 = new Lingkaran(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            lingkaran6 = new Lingkaran(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            oval9 = new Lingkaran(new Vector3(1.0f, 0.93f, 0.4f), new Vector3(positionX, positionY, positionZ));
            balok8 = new Balok(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            balok9 = new Balok(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            balok10 = new Balok(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            balok11 = new Balok(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            balok12 = new Balok(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            balok13 = new Balok(new Vector3(0, 0, 0), new Vector3(positionX, positionY, positionZ));
            
            curva = new Curva(new Vector3(0f, 0f, 0f), new Vector3(positionX, positionY, positionZ));
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

            tabung5.createTube(tabung1.getPos().X - tabung1.getrad() * 1.5f, tabung1.getPos().Y - tabung1.getheight() * 3.5f, tabung1.getPos().Z, 100, tabung1.getrad() / 5, tabung1.getheight() * 3);
            tabung5.load(sizeX, sizeY);

            tabung6.createTube(tabung2.getPos().X - tabung2.getrad() * 0.5f , tabung2.getPos().Y - tabung2.getheight() * 3.5f, tabung2.getPos().Z, 100, tabung2.getrad() / 5, tabung2.getheight() * 3);
            tabung6.load(sizeX, sizeY);

            tabung7.createTube(tabung3.getPos().X - tabung3.getrad(), tabung3.getPos().Y - tabung3.getheight() * 2, tabung3.getPos().Z, 100, tabung3.getrad() / 6, tabung3.getheight());
            tabung7.load(sizeX, sizeY);

            tabung8.createTube(tabung4.getPos().X - tabung4.getrad(), tabung4.getPos().Y - tabung4.getheight() * 2, tabung3.getPos().Z, 100, tabung4.getrad() / 6, tabung4.getheight());
            tabung8.load(sizeX, sizeY);

            tabung9.createTube(tabung7.getPos().X - tabung7.getrad(), tabung7.getPos().Y - tabung7.getheight() * 2, tabung7.getPos().Z, 100, tabung7.getrad(), tabung7.getheight());
            tabung9.load(sizeX, sizeY);

            tabung10.createTube(tabung8.getPos().X - tabung8.getrad(), tabung8.getPos().Y - tabung8.getheight() * 2, tabung8.getPos().Z, 100, tabung8.getrad(), tabung8.getheight());
            tabung10.load(sizeX, sizeY);

            balok4.createCube(tabung5.getPos().X - tabung5.getrad(), tabung5.getPos().Y - tabung5.getheight(), tabung5.getPos().Z, tabung5.getrad() * 5, tabung5.getrad() * 4, tabung5.getrad());
            balok4.load(sizeX, sizeY);

            balok5.createCube(tabung6.getPos().X - tabung6.getrad(), tabung6.getPos().Y - tabung6.getheight(), tabung6.getPos().Z, tabung6.getrad() * 5, tabung6.getrad() * 4, tabung6.getrad());
            balok5.load(sizeX, sizeY);

            oval1.createSphere(balok5.getPos().X + balok5.getlenx() / 2, balok5.getPos().Y - balok5.getleny() / 1.5f, balok5.getPos().Z, balok5.getlenx() / 6, balok5.getleny() / 1.5f, balok5.getlenz() / 3, 1000, 1000);
            oval1.load(sizeX, sizeY);

            oval2.createSphere(balok5.getPos().X + balok5.getlenx() / 6, balok5.getPos().Y - balok5.getleny() / 1.5f, balok5.getPos().Z, balok5.getlenx() / 6, balok5.getleny(), balok5.getlenz() / 3, 1000, 1000);
            oval2.load(sizeX, sizeY);

            oval3.createSphere(balok5.getPos().X - balok5.getlenx() / 6, balok5.getPos().Y - balok5.getleny() / 1.5f, balok5.getPos().Z, balok5.getlenx() / 6, balok5.getleny(), balok5.getlenz() / 3, 1000, 1000);
            oval3.load(sizeX, sizeY);

            oval4.createSphere(balok5.getPos().X - balok5.getlenx() / 2, balok5.getPos().Y - balok5.getleny() / 1.5f, balok5.getPos().Z, balok5.getlenx() / 6, balok5.getleny() / 2, balok5.getlenz() / 3, 1000, 1000);
            oval4.load(sizeX, sizeY);

            oval5.createSphere(balok4.getPos().X + balok4.getlenx() / 2, balok4.getPos().Y - balok4.getleny() / 1.5f, balok4.getPos().Z, balok4.getlenx() / 6, balok4.getleny() / 2, balok4.getlenz() / 3, 1000, 1000);
            oval5.load(sizeX, sizeY);

            oval6.createSphere(balok4.getPos().X + balok4.getlenx() / 6, balok4.getPos().Y - balok4.getleny() / 1.5f, balok4.getPos().Z, balok4.getlenx() / 6, balok4.getleny(), balok4.getlenz() / 3, 1000, 1000);
            oval6.load(sizeX, sizeY);

            oval7.createSphere(balok4.getPos().X - balok4.getlenx() / 6, balok4.getPos().Y - balok4.getleny() / 1.5f, balok4.getPos().Z, balok4.getlenx() / 6, balok4.getleny(), balok4.getlenz() / 3, 1000, 1000);
            oval7.load(sizeX, sizeY);

            oval8.createSphere(balok4.getPos().X - balok4.getlenx() / 2, balok4.getPos().Y - balok4.getleny() / 1.5f, balok4.getPos().Z, balok4.getlenx() / 6, balok4.getleny() / 1.5f, balok4.getlenz() / 3, 1000, 1000);
            oval8.load(sizeX, sizeY);

            balok6.createCube(tabung9.getPos().X - tabung9.getrad(), tabung9.getPos().Y - tabung9.getheight(), tabung9.getPos().Z + tabung9.getrad() * 3, tabung9.getrad() * 5, tabung9.getheight() / 2f, tabung9.getrad() * 12);
            balok6.load(sizeX, sizeY);

            balok7.createCube(tabung10.getPos().X - tabung10.getrad() / 1.5f, tabung10.getPos().Y - tabung10.getheight(), tabung10.getPos().Z + tabung10.getrad() * 3, tabung10.getrad() * 5, tabung10.getheight() / 2f, tabung10.getrad() * 12);
            balok7.load(sizeX, sizeY);

            lingkaran3.createSphere(lingkaran1.getPos().X, lingkaran1.getPos().Y, lingkaran1.getPos().Z + lingkaran1.getradz() / 1.5f, lingkaran1.getradx() / 2f, lingkaran1.getrady() / 2f, lingkaran1.getradz() / 2, 1000, 1000);
            lingkaran3.load(sizeX, sizeY);

            lingkaran4.createSphere(lingkaran2.getPos().X, lingkaran2.getPos().Y, lingkaran2.getPos().Z + lingkaran2.getradz() / 1.5f, lingkaran2.getradx() / 2f, lingkaran2.getrady() / 2f, lingkaran2.getradz() / 2, 1000, 1000);
            lingkaran4.load(sizeX, sizeY);

            lingkaran5.createSphere(lingkaran3.getPos().X, lingkaran3.getPos().Y, lingkaran3.getPos().Z + lingkaran3.getradz(), lingkaran3.getradx() / 2, lingkaran3.getrady() / 2, lingkaran3.getradz() / 2, 1000, 1000);
            lingkaran5.load(sizeX, sizeY);

            lingkaran6.createSphere(lingkaran4.getPos().X, lingkaran4.getPos().Y, lingkaran4.getPos().Z + lingkaran4.getradz(), lingkaran4.getradx() / 2, lingkaran4.getrady() / 2, lingkaran4.getradz() / 2, 1000, 1000);
            lingkaran6.load(sizeX, sizeY);

            oval9.createSphere(balok1.getPos().X, balok1.getPos().Y, balok1.getPos().Z + balok1.getlenz() / 2, balok1.getlenx() / 25, balok1.getleny() / 25, balok1.getlenz() / 2, 1000, 1000);
            oval9.load(sizeX, sizeY);

            balok8.createCube(lingkaran1.getPos().X, lingkaran1.getPos().Y + lingkaran1.getrady() * 1.25f, lingkaran1.getPos().Z, lingkaran1.getradx() / 5, lingkaran1.getrady() / 3f, lingkaran1.getradz() / 2);
            balok8.load(sizeX, sizeY);

            balok9.createCube(lingkaran1.getPos().X - lingkaran1.getradx() / 2, lingkaran1.getPos().Y + lingkaran1.getrady() * 1.15f, lingkaran1.getPos().Z, lingkaran1.getradx() / 5, lingkaran1.getrady() / 3f, lingkaran1.getradz() / 2);
            balok9.load(sizeX, sizeY);
            balok9.rotatecenter(30, 'z');

            balok10.createCube(lingkaran1.getPos().X + lingkaran1.getradx() / 2, lingkaran1.getPos().Y + lingkaran1.getrady() * 1.15f, lingkaran1.getPos().Z, lingkaran1.getradx() / 5, lingkaran1.getrady() / 3f, lingkaran1.getradz() / 2);
            balok10.load(sizeX, sizeY);
            balok10.rotatecenter(-30, 'z');

            balok11.createCube(lingkaran2.getPos().X, lingkaran2.getPos().Y + lingkaran2.getrady() * 1.25f, lingkaran2.getPos().Z, lingkaran2.getradx() / 5, lingkaran2.getrady() / 3f, lingkaran2.getradz() / 2);
            balok11.load(sizeX, sizeY);

            balok12.createCube(lingkaran2.getPos().X + lingkaran2.getradx() / 2f, lingkaran2.getPos().Y + lingkaran2.getrady() * 1.15f, lingkaran2.getPos().Z, lingkaran2.getradx() / 5, lingkaran2.getrady() / 3f, lingkaran2.getradz() / 2);
            balok12.load(sizeX, sizeY);
            balok12.rotatecenter(-30, 'z');

            balok13.createCube(lingkaran2.getPos().X - lingkaran1.getradx() / 2f, lingkaran2.getPos().Y + lingkaran2.getrady() * 1.15f, lingkaran2.getPos().Z, lingkaran2.getradx() / 5, lingkaran2.getrady() / 3f, lingkaran2.getradz() / 2);
            balok13.load(sizeX, sizeY);
            balok13.rotatecenter(30, 'z');

            curva.createEllipsoidVertices(balok1.getPos().X, balok1.getPos().Y - balok1.getleny() / 4.5f, balok1.getPos().Z + balok1.getlenz() / 1.95f, balok1.getlenx() / 30, balok1.getleny() / 2, 0f, 0.5f);
            curva.load(sizeX, sizeY);
            curva.rotatecenter(90, 'x');
            curva.rotatecenter(180, 'y');
            curva.rotatecenter(90, 'z');
        }

        public void render(Camera _camera)
        {
            balok1.CameraMovement(_camera);
            balok1.render();

            balok2.CameraMovement(_camera);
            balok2.render();

            balok3.CameraMovement(_camera);
            balok3.render();

            lingkaran1.CameraMovement(_camera);
            lingkaran1.render();

            lingkaran2.CameraMovement(_camera);
            lingkaran2.render();

            tabung1.CameraMovement(_camera);
            tabung1.render();

            tabung2.CameraMovement(_camera);
            tabung2.render();

            tabung3.CameraMovement(_camera);
            tabung3.render();

            tabung4.CameraMovement(_camera);
            tabung4.render();

            tabung5.CameraMovement(_camera);
            tabung5.render();

            tabung6.CameraMovement(_camera);
            tabung6.render();

            tabung7.CameraMovement(_camera);
            tabung7.render();

            tabung8.CameraMovement(_camera);
            tabung8.render();

            tabung9.CameraMovement(_camera);
            tabung9.render();

            tabung10.CameraMovement(_camera);
            tabung10.render();

            balok4.CameraMovement(_camera);
            balok4.render();

            balok5.CameraMovement(_camera);
            balok5.render();

            oval1.CameraMovement(_camera);
            oval1.render();

            oval2.CameraMovement(_camera);
            oval2.render();

            oval3.CameraMovement(_camera);
            oval3.render();

            oval4.CameraMovement(_camera);
            oval4.render();

            oval5.CameraMovement(_camera);
            oval5.render();

            oval6.CameraMovement(_camera);
            oval6.render();

            oval7.CameraMovement(_camera);
            oval7.render();

            oval8.CameraMovement(_camera);
            oval8.render();

            balok6.CameraMovement(_camera);
            balok6.render();

            balok7.CameraMovement(_camera);
            balok7.render();

            lingkaran3.CameraMovement(_camera);
            lingkaran3.render();

            lingkaran4.CameraMovement(_camera);
            lingkaran4.render();

            lingkaran5.CameraMovement(_camera);
            lingkaran5.render();

            lingkaran6.CameraMovement(_camera);
            lingkaran6.render();

            oval9.CameraMovement(_camera);
            oval9.render();

            balok8.CameraMovement(_camera);
            balok8.render();

            balok9.CameraMovement(_camera);
            balok9.render();

            balok10.CameraMovement(_camera);
            balok10.render();

            balok11.CameraMovement(_camera);
            balok11.render();

            balok12.CameraMovement(_camera);
            balok12.render();

            balok13.CameraMovement(_camera);
            balok13.render();

            curva.CameraMovement(_camera);
            curva.render();
        }

        public void rotate(float angle, char x)
        {
            balok1.rotate(angle, x);
            balok2.rotate(angle, x);
            balok3.rotate(angle, x);
            lingkaran1.rotate(angle, x);
            lingkaran2.rotate(angle, x);
            tabung1.rotate(angle, x);
            tabung2.rotate(angle, x);
            tabung3.rotate(angle, x);
            tabung4.rotate(angle, x);
            tabung5.rotate(angle, x);
            tabung6.rotate(angle, x);
            tabung7.rotate(angle, x);
            tabung8.rotate(angle, x);
            tabung9.rotate(angle, x);
            tabung10.rotate(angle, x);
            balok4.rotate(angle, x);
            balok5.rotate(angle, x);
            oval1.rotate(angle, x);
            oval2.rotate(angle, x);
            oval3.rotate(angle, x);
            oval4.rotate(angle, x);
            oval5.rotate(angle, x);
            oval6.rotate(angle, x);
            oval7.rotate(angle, x);
            oval8.rotate(angle, x);
            balok6.rotate(angle, x);
            balok7.rotate(angle, x);
            lingkaran3.rotate(angle, x);
            lingkaran4.rotate(angle, x);
            lingkaran5.rotate(angle, x);
            lingkaran6.rotate(angle, x);
            oval9.rotate(angle, x);
            balok8.rotate(angle, x);
            balok9.rotate(angle, x);
            balok10.rotate(angle, x);
            balok11.rotate(angle, x);
            balok12.rotate(angle, x);
            balok13.rotate(angle, x);
            
            curva.rotate(angle, x);
        }
        
        public void rotatepoint(float angle, char x, Vector3 pos)
        {
            balok1.rotatepoint(angle, x);
            balok2.rotatepoint(angle, x);
            balok3.rotatepoint(angle, x);
            lingkaran1.rotatepoint(angle, x);
            lingkaran2.rotatepoint(angle, x);
            tabung1.rotatepoint(angle, x);
            tabung2.rotatepoint(angle, x);
            tabung3.rotatepoint(angle, x);
            tabung4.rotatepoint(angle, x);
            tabung5.rotatepoint(angle, x);
            tabung6.rotatepoint(angle, x);
            tabung7.rotatepoint(angle, x);
            tabung8.rotatepoint(angle, x);
            tabung9.rotatepoint(angle, x);
            tabung10.rotatepoint(angle, x);
            balok4.rotatepoint(angle, x);
            balok5.rotatepoint(angle, x);
            oval1.rotatepoint(angle, x);
            oval2.rotatepoint(angle, x);
            oval3.rotatepoint(angle, x);
            oval4.rotatepoint(angle, x);
            oval5.rotatepoint(angle, x);
            oval6.rotatepoint(angle, x);
            oval7.rotatepoint(angle, x);
            oval8.rotatepoint(angle, x);
            balok6.rotatepoint(angle, x);
            balok7.rotatepoint(angle, x);
            lingkaran3.rotatepoint(angle, x);
            lingkaran4.rotatepoint(angle, x);
            lingkaran5.rotatepoint(angle, x);
            lingkaran6.rotatepoint(angle, x);
            oval9.rotatepoint(angle, x);
            balok8.rotatepoint(angle, x);
            balok9.rotatepoint(angle, x);
            balok10.rotatepoint(angle, x);
            balok11.rotatepoint(angle, x);
            balok12.rotatepoint(angle, x);
            balok13.rotatepoint(angle, x);

            curva.rotatepoint(angle, x);
        }

        public void scale(float m)
        {
            balok1.scale(m);
            balok2.scale(m);
            balok3.scale(m);
            lingkaran1.scale(m);
            lingkaran2.scale(m);
            tabung1.scale(m);
            tabung2.scale(m);
            tabung3.scale(m);
            tabung4.scale(m);
            tabung5.scale(m);
            tabung6.scale(m);
            tabung7.scale(m);
            tabung8.scale(m);
            tabung9.scale(m);
            tabung10.scale(m);
            balok4.scale(m);
            balok5.scale(m);
            oval1.scale(m);
            oval2.scale(m);
            oval3.scale(m);
            oval4.scale(m);
            oval5.scale(m);
            oval6.scale(m);
            oval7.scale(m);
            oval8.scale(m);
            balok6.scale(m);
            balok7.scale(m);
            lingkaran3.scale(m);
            lingkaran4.scale(m);
            lingkaran5.scale(m);
            lingkaran6.scale(m);
            oval9.scale(m);
            balok8.scale(m);
            balok9.scale(m);
            balok10.scale(m);
            balok11.scale(m);
            balok12.scale(m);
            balok13.scale(m);

            curva.scale(m);
        }

        public void animate(double time)
        {
            balok1.animation(time);
            balok2.animation(time);
            balok3.animation(time);
            lingkaran1.animation(time);
            lingkaran2.animation(time);
            tabung1.animation(time);
            tabung2.animation(time);
            tabung3.animation(time);
            tabung4.animation(time);
            tabung5.animation(time);
            tabung6.animation(time);
            tabung7.animation(time);
            tabung8.animation(time);
            tabung9.animation(time);
            tabung10.animation(time);
            balok4.animation(time);
            balok5.animation(time);
            oval1.animation(time);
            oval2.animation(time);
            oval3.animation(time);
            oval4.animation(time);
            oval5.animation(time);
            oval6.animation(time);
            oval7.animation(time);
            oval8.animation(time);
            balok6.animation(time);
            balok7.animation(time);
            lingkaran3.animation(time);
            lingkaran4.animation(time);
            lingkaran5.animation(time);
            lingkaran6.animation(time);
            oval9.animation(time);
            balok8.animation(time);
            balok9.animation(time);
            balok10.animation(time);
            balok11.animation(time);
            balok12.animation(time);
            balok13.animation(time);

            curva.animation(time);

            /*switch (animate_number)
            {
                case 0:
                    //Console.WriteLine(plank.getPosY() + " " + (box1.getPosY() + box1.getLengthX()));
                    balok1.translate(0.01f, 'y');
                    if (balok1.getPos().Y >= box1.getPosY() + box1.getLengthX() - 0.05f)
                    {
                        animate_number++;
                        plank.translate(0f, 'y');
                    }
                    break;

                case 1:
                    //Console.WriteLine(plank.getPosY() + " " + (box1.getPosY() + box1.getLengthX()));
                    plank.translate(-0.01f, 'y');
                    if (plank.getPosY() <= box1.getPosY())
                    {
                        animate_number++;
                        plank.translate(0f, 'y');
                    }
                    break;
                case 2:
                    //Console.WriteLine(plank.getPosY() + " " + (box1.getPosY() + box1.getLengthX()));
                    plank.translate(0.01f, 'y');
                    if (plank.getPosY() >= box1.getPosY() + box1.getLengthX() - 0.05f)
                    {
                        animate_number++;
                        plank.translate(0f, 'y');
                    }
                    break;

                case 3:
                    //Console.WriteLine(plank.getPosY() + " " + (box1.getPosY() + box1.getLengthX()));
                    plank.translate(-0.01f, 'y');
                    if (plank.getPosY() <= box1.getPosY())
                    {
                        animate_number++;
                        plank.translate(0f, 'y');
                    }
                    break;
                case 4:

                    if (angle <= 10 && angle >= 0)
                    {
                        translate(-0.1f, 'z');
                    }
                    else if (angle >= 80 && angle <= 100)
                    {
                        translate(-0.1f, 'x');

                    }
                    else if (angle >= 170 && angle <= 190)
                    {

                        translate(0.1f, 'z');

                    }
                    else if (angle >= 260 && angle <= 280)
                    {
                        translate(0.1f, 'x');
                    }

                    counter += 0.1f;
                    if (counter >= 10f)
                    {
                        animate_number++;
                        counter = 0;

                    }
                    break;
                case 5:
                    rotatecenter(1f, 'y');
                    angle += 1f;

                    if (angle >= 360f)
                    {
                        angle = 0;
                        animate_number = 0;
                    }
                    else if (angle >= 90f && angle < 90.5f)
                    {
                        animate_number = 0;
                    }
                    else if (angle >= 180f && angle < 180.5f)
                    {
                        animate_number = 0;
                    }
                    else if (angle >= 270f && angle < 270.5f)
                    {
                        animate_number = 0;
                    }
                    Console.WriteLine(angle);
                    break;

                default: break;
            }*/
        }

        public Vector3 getPos() { return new Vector3(positionX, positionY, positionZ); }
    }
}
