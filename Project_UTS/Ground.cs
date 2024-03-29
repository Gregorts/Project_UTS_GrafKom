﻿using OpenTK.Mathematics;
using LearnOpenTK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Ground
    {
        protected float positionX, positionY, positionZ;

        protected Balok balok1, balok2, balok3, balok4;

        public Ground(float posX = 1f, float posY = 0.5f, float posZ = 0f)
        {
            this.positionX = posX;
            this.positionY = posY;
            this.positionZ = posZ;

            balok1 = new Balok(new Vector3(0.76f, 0.698f, 0.5f), new Vector3(positionX, positionY, positionZ));
            balok2 = new Balok(new Vector3(0.58f, 0.84f, 0.98f), new Vector3(positionX, positionY, positionZ));
            balok3 = new Balok(new Vector3(0.58f, 0.84f, 0.98f), new Vector3(positionX, positionY, positionZ));
            balok4 = new Balok(new Vector3(0.58f, 0.84f, 0.98f), new Vector3(positionX, positionY, positionZ));
        }

        public void load(int sizeX, int sizeY)
        {
            balok1.createCube(positionX, positionY, positionZ, 30f, 2f, 10f);
            balok1.load(sizeX, sizeY);
            balok2.createCube(balok1.getPos().X + balok1.getlenx() / 2.15f, balok1.getPos().Y + balok1.getleny() * 4f, balok1.getPos().Z, balok1.getleny(), balok1.getlenx() / 1.7f, balok1.getlenz());
            balok2.load(sizeX, sizeY);
            balok3.createCube(balok1.getPos().X - balok1.getlenx() / 2.15f, balok1.getPos().Y + balok1.getleny() * 4f, balok1.getPos().Z, balok1.getleny(), balok1.getlenx() / 1.7f, balok1.getlenz());
            balok3.load(sizeX, sizeY);
            balok4.createCube(balok1.getPos().X, balok1.getPos().Y + balok1.getleny() * 4f, balok1.getPos().Z - balok1.getlenz() / 2.15f, balok1.getlenx(), balok1.getlenx() / 1.7f, balok1.getleny());
            balok4.load(sizeX, sizeY);
        }

        public void render(Camera _camera)
        {
            balok1.CameraMovement(_camera);
            balok1.render();

            balok2.CameraMovement(_camera);
            balok2.render();

            balok3.CameraMovement(_camera);
            balok3.render();

            balok4.CameraMovement(_camera);
            balok4.render();
        }

        public void scale(float m)
        {
            balok1.scale(m);
            balok2.scale(m);
            balok3.scale(m);
            balok4.scale(m);
        }

        public void rotate(float angle, char x)
        {
            balok1.rotate(angle, x);
            balok2.rotate(angle, x);
            balok3.rotate(angle, x);
            balok4.rotate(angle, x);

        }

        public void rotatecenter(float angle, char x)
        {
            balok1.rotatecenter(angle, x);
            balok2.rotatecenter(angle, x);
            balok3.rotatecenter(angle, x);
            balok4.rotatecenter(angle, x);
        }
        public void rotatepoint(float angle, char x)
        {
            balok1.rotatepoint(angle, x);
            balok2.rotatepoint(angle, x);
            balok3.rotatepoint(angle, x);
            balok4.rotatepoint(angle, x);
        }
    }
}
