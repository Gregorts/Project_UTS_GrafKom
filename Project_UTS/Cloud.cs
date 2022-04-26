using OpenTK.Mathematics;
using LearnOpenTK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Cloud
    {
        protected float positionX, positionY, positionZ;

        protected Tabung tabung1, tabung2, tabung3, tabung4, tabung5, tabung6, tabung7, tabung8;

        int c_animate = 0;

        public Cloud(float posX = 1f, float posY = 0.5f, float posZ = 0f)
        {
            positionX = posX;
            positionY = posY;
            positionZ = posZ;

            tabung1 = new Tabung(new Vector3(0.87f, 0.98f, 1f), new Vector3(positionX, positionY, positionZ));
            tabung2 = new Tabung(new Vector3(0.87f, 0.98f, 1f), new Vector3(positionX, positionY, positionZ));
            tabung3 = new Tabung(new Vector3(0.87f, 0.98f, 1f), new Vector3(positionX, positionY, positionZ));
            tabung4 = new Tabung(new Vector3(0.87f, 0.98f, 1f), new Vector3(positionX, positionY, positionZ));
            tabung5 = new Tabung(new Vector3(0.87f, 0.98f, 1f), new Vector3(positionX, positionY, positionZ));
            tabung6 = new Tabung(new Vector3(0.87f, 0.98f, 1f), new Vector3(positionX, positionY, positionZ));
            tabung7 = new Tabung(new Vector3(0.87f, 0.98f, 1f), new Vector3(positionX, positionY, positionZ));
        }

        public void load(int sizeX, int sizeY)
        {
            tabung1.createTube(positionX, positionY, positionZ, 100, 1f, 0.5f);
            tabung1.load(sizeX, sizeY);
            tabung1.rotatecenter(90, 'x');

            tabung2.createTube(tabung1.getPos().X + tabung1.getrad(), tabung1.getPos().Y, tabung1.getPos().Z, 100, tabung1.getrad(), tabung1.getheight());
            tabung2.load(sizeX, sizeY);
            tabung2.rotatecenter(90, 'x');

            tabung3.createTube(tabung2.getPos().X - tabung2.getrad() * 2.5f, tabung2.getPos().Y + tabung2.getrad(), tabung2.getPos().Z, 100, tabung2.getrad(), tabung2.getheight());
            tabung3.load(sizeX, sizeY);
            tabung3.rotatecenter(90, 'x');

            tabung4.createTube(tabung3.getPos().X + tabung3.getrad(), tabung3.getPos().Y, tabung3.getPos().Z, 100, tabung3.getrad(), tabung3.getheight());
            tabung4.load(sizeX, sizeY);
            tabung4.rotatecenter(90, 'x');

            tabung5.createTube(tabung4.getPos().X + tabung4.getrad() * 0.5f, tabung4.getPos().Y - tabung4.getrad() * 2, tabung4.getPos().Z, 100, tabung4.getrad(), tabung4.getheight());
            tabung5.load(sizeX, sizeY);
            tabung5.rotatecenter(90, 'x');

            tabung6.createTube(tabung5.getPos().X - tabung5.getrad() * 1.5f, tabung5.getPos().Y - tabung5.getrad() * 2.5f, tabung5.getPos().Z, 100, tabung5.getrad(), tabung5.getheight());
            tabung6.load(sizeX, sizeY);
            tabung6.rotatecenter(90, 'x');

            tabung7.createTube(tabung6.getPos().X - tabung6.getrad() * 3f, tabung6.getPos().Y - tabung6.getrad(), tabung6.getPos().Z, 100, tabung6.getrad(), tabung6.getheight());
            tabung7.load(sizeX, sizeY);
            tabung7.rotatecenter(90, 'x');
        }

        public void render(Camera _camera)
        {
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
        }

        public void scale(float m)
        {
            tabung1.scale(m);
            tabung2.scale(m);
            tabung3.scale(m);
            tabung4.scale(m);
            tabung5.scale(m);
            tabung6.scale(m);
            tabung7.scale(m);
        }

        public void rotate(float angle, char x)
        {
            tabung1.rotate(angle, x);
            tabung2.rotate(angle, x);
            tabung3.rotate(angle, x);
            tabung4.rotate(angle, x);
            tabung5.rotate(angle, x);
            tabung6.rotate(angle, x);
            tabung7.rotate(angle, x);
        }

        public void rotatecenter(float angle, char x)
        {
            tabung1.rotatecenter(angle, x);
            tabung2.rotatecenter(angle, x);
            tabung3.rotatecenter(angle, x);
            tabung4.rotatecenter(angle, x);
            tabung5.rotatecenter(angle, x);
            tabung6.rotatecenter(angle, x);
            tabung7.rotatecenter(angle, x);
        }

        public void rotatepoint(float angle, char x)
        {
            tabung1.rotatepoint(angle, x);
            tabung2.rotatepoint(angle, x);
            tabung3.rotatepoint(angle, x);
            tabung4.rotatepoint(angle, x);
            tabung5.rotatepoint(angle, x);
            tabung6.rotatepoint(angle, x);
            tabung7.rotatepoint(angle, x);
        }

        public void translateright()
        {
            tabung1.translateright();
            tabung2.translateright();
            tabung3.translateright();
            tabung4.translateright();
            tabung5.translateright();
            tabung6.translateright();
            tabung7.translateright();
        }

        public void translateleft()
        {
            tabung1.translateleft();
            tabung2.translateleft();
            tabung3.translateleft();
            tabung4.translateleft();
            tabung5.translateleft();
            tabung6.translateleft();
            tabung7.translateleft();
        }

        public void setcolor(Vector3 color)
        {
            tabung1.setcolor(color);
            tabung2.setcolor(color);
            tabung3.setcolor(color);
            tabung4.setcolor(color);
            tabung5.setcolor(color);
            tabung6.setcolor(color);
            tabung7.setcolor(color);
        }

        public void animate()
        {
            if(c_animate <= 120)
            {
                translateright();
                setcolor(new Vector3(0.87f, 0.98f, 1f));
            }
            else if(c_animate > 120 && c_animate <= 240)
            {
                translateleft();
                setcolor(new Vector3(0.58f, 0.84f, 0.98f));
            }
            else
            {   
                c_animate = 0;
            }
            c_animate++;
        }
    }
}
