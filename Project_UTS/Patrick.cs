using LearnOpenTK.Common;
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
        protected Curva curva;

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
            curva = new Curva(new Vector3(0f, 0f, 0f), new Vector3(positionX, positionY, positionZ));
        }

        public void load(int sizeX, int sizeY)
        {
            cone1.createCone(positionX, positionY, positionZ, 1.5f, 4f, 10000);
            cone1.load(sizeX, sizeY);

            halflingkaran1.createHalfSphere(cone1.getPos().X, cone1.getPos().Y, cone1.getPos().Z, cone1.getrad(), cone1.getrad(), cone1.getrad(), 1000, 1000);
            halflingkaran1.load(sizeX, sizeY);
            halflingkaran1.rotatecenter(180, 'z');

            lingkaran1.createSphere(cone1.getPos().X + cone1.getrad() * 0.15f, cone1.getPos().Y + cone1.getheight() / 2, cone1.getPos().Z + cone1.getrad() / 2.5f, cone1.getrad() / 6, cone1.getrad() / 5, cone1.getrad() / 6, 1000, 1000);
            lingkaran1.load(sizeX, sizeY);

            lingkaran2.createSphere(cone1.getPos().X - cone1.getrad() * 0.15f, cone1.getPos().Y + cone1.getheight() / 2, cone1.getPos().Z + cone1.getrad() / 2.5f, cone1.getrad() / 6, cone1.getrad() / 5, cone1.getrad() / 6, 1000, 1000);
            lingkaran2.load(sizeX, sizeY);

            cone2.createCone(cone1.getPos().X - cone1.getrad() / 2f, cone1.getPos().Y + cone1.getheight() / 4, cone1.getPos().Z, cone1.getrad() / 3, cone1.getheight() / 2.5f, 10000);
            cone2.load(sizeX, sizeY);
            cone2.rotatecenter(45, 'z');

            cone3.createCone(cone1.getPos().X + cone1.getrad() / 2f, cone1.getPos().Y + cone1.getheight() / 4, cone1.getPos().Z, cone1.getrad() / 3, cone1.getheight() / 2.5f, 10000);
            cone3.load(sizeX, sizeY);
            cone3.rotatecenter(-45, 'z');

            tabung1.createTube(halflingkaran1.getPos().X - halflingkaran1.getradx() / 2f, halflingkaran1.getPos().Y - halflingkaran1.getrady() * 1.05f, halflingkaran1.getPos().Z, 100, halflingkaran1.getradx() / 3, halflingkaran1.getrady() / 1.5f);
            tabung1.load(sizeX, sizeY);
            
            tabung2.createTube(halflingkaran1.getPos().X + halflingkaran1.getradx() / 2f, halflingkaran1.getPos().Y - halflingkaran1.getrady() * 1.05f, halflingkaran1.getPos().Z, 100, halflingkaran1.getradx() / 3, halflingkaran1.getrady() / 1.5f);
            tabung2.load(sizeX, sizeY);

            cone4.createCone(tabung1.getPos().X - tabung1.getrad(), tabung1.getPos().Y - tabung1.getheight(), tabung1.getPos().Z, tabung1.getrad() / 1.5f, tabung1.getheight(), 10000);
            cone4.load(sizeX, sizeY);
            cone4.rotatecenter(180, 'z');

            cone5.createCone(tabung2.getPos().X - tabung2.getrad(), tabung2.getPos().Y - tabung2.getheight(), tabung2.getPos().Z, tabung2.getrad() / 1.5f, tabung2.getheight(), 10000);
            cone5.load(sizeX, sizeY);
            cone5.rotatecenter(180, 'z');

            lingkaran3.createSphere(lingkaran1.getPos().X, lingkaran1.getPos().Y, lingkaran1.getPos().Z + lingkaran1.getradz(), lingkaran1.getradx() / 3, lingkaran1.getrady() / 4, lingkaran1.getradz() / 5, 1000, 1000);
            lingkaran3.load(sizeX, sizeY);

            lingkaran4.createSphere(lingkaran2.getPos().X, lingkaran1.getPos().Y, lingkaran1.getPos().Z + lingkaran1.getradz(), lingkaran2.getradx() / 3, lingkaran2.getrady() / 4, lingkaran2.getradz() / 5, 1000, 1000);
            lingkaran4.load(sizeX, sizeY);

            curva.createEllipsoidVertices(cone1.getPos().X, cone1.getPos().Y + cone1.getrad() / 1.25f, cone1.getPos().Z + cone1.getrad() / 1.3f, cone1.getrad() / 30, cone1.getheight() / 4, 0f, 0.5f);
            curva.load(sizeX, sizeY);
            curva.rotatecenter(90, 'x');
            curva.rotatecenter(180, 'y');
            curva.rotatecenter(90, 'z');
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

            curva.CameraMovement(_camera);
            curva.render();
        }

        public void rotate(float angle, char x)
        {
            cone1.rotate(angle, x);
            halflingkaran1.rotate(angle, x);
            lingkaran1.rotate(angle, x);
            lingkaran2.rotate(angle, x);
            cone2.rotate(angle, x);
            cone3.rotate(angle, x);
            tabung1.rotate(angle, x);
            tabung2.rotate(angle, x);
            cone4.rotate(angle, x);
            cone5.rotate(angle, x);
            lingkaran3.rotate(angle, x);
            lingkaran4.rotate(angle, x);
            curva.rotate(angle, x);
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
            curva.scale(m);
        }

        public void translateup()
        {
            cone1.translateup();
            halflingkaran1.translateup();
            lingkaran1.translateup();
            lingkaran2.translateup();
            cone2.translateup();
            cone3.translateup();
            tabung1.translateup();
            tabung2.translateup();
            cone4.translateup();
            cone5.translateup();
            lingkaran3.translateup();
            lingkaran4.translateup();
            curva.translateup();
        }

        public void translatedown()
        {
            cone1.translatedown();
            halflingkaran1.translatedown();
            lingkaran1.translatedown();
            lingkaran2.translatedown();
            cone2.translatedown();
            cone3.translatedown();
            tabung1.translatedown();
            tabung2.translatedown();
            cone4.translatedown();
            cone5.translatedown();
            lingkaran3.translatedown();
            lingkaran4.translatedown();
            curva.translatedown();
        }

        public void translateright()
        {
            cone1.translateright();
            halflingkaran1.translateright();
            lingkaran1.translateright();
            lingkaran2.translateright();
            cone2.translateright();
            cone3.translateright();
            tabung1.translateright();
            tabung2.translateright();
            cone4.translateright();
            cone5.translateright();
            lingkaran3.translateright();
            lingkaran4.translateright();
            curva.translateright();
        }

        public void translateleft()
        {
            cone1.translateleft();
            halflingkaran1.translateleft();
            lingkaran1.translateleft();
            lingkaran2.translateleft();
            cone2.translateleft();
            cone3.translateleft();
            tabung1.translateleft();
            tabung2.translateleft();
            cone4.translateleft();
            cone5.translateleft();
            lingkaran3.translateleft();
            lingkaran4.translateleft();
            curva.translateleft();
        }

        public void translatefront()
        {
            cone1.translatefront();
            halflingkaran1.translatefront();
            lingkaran1.translatefront();
            lingkaran2.translatefront();
            cone2.translatefront();
            cone3.translatefront();
            tabung1.translatefront();
            tabung2.translatefront();
            cone4.translatefront();
            cone5.translatefront();
            lingkaran3.translatefront();
            lingkaran4.translatefront();
            curva.translatefront();
        }

        public void translateback()
        {
            cone1.translateback();
            halflingkaran1.translateback();
            lingkaran1.translateback();
            lingkaran2.translateback();
            cone2.translateback();
            cone3.translateback();
            tabung1.translateback();
            tabung2.translateback();
            cone4.translateback();
            cone5.translateback();
            lingkaran3.translateback();
            lingkaran4.translateback();
            curva.translateback();
        }

        public void animate(double time, float angle, char x, Vector3 pos)
        {
            cone1.animation(time, angle, x, pos);
            halflingkaran1.animation(time, angle, x, pos);
            lingkaran1.animation(time, angle, x, pos);
            lingkaran2.animation(time, angle, x, pos);
            cone2.animation(time, angle, x, pos);
            cone3.animation(time, angle, x, pos);
            tabung1.animation(time, angle, x, pos);
            tabung2.animation(time, angle, x, pos);
            cone4.animation(time, angle, x, pos);
            cone5.animation(time, angle, x, pos);
            lingkaran3.animation(time, angle, x, pos);
            lingkaran4.animation(time, angle, x, pos);
            curva.animation(time, angle, x, pos);
        }

        public Vector3 getPos() { return new Vector3(positionX, positionY, positionZ); }
    }
}
