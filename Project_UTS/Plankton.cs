﻿using LearnOpenTK.Common;
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
        protected Kerucut kaki1, kaki2;

        // tangan
        protected Kerucut tangan1, tangan2;

        // antena
        protected Balok antena1, antena2;

        // alis
        protected Balok alis;

        // mulut
        protected Curva mulut;

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

            mulut = new Curva(new Vector3(0f, 0f, 0f), new Vector3(positionX, positionY, positionZ));
        }

        public void load(int sizeX, int sizeY)
        {
            badan.createSphere(positionX, positionY, positionZ, 1f, 2f, 1f, 1000, 1000);
            badan.load(sizeX, sizeY);

            mata.createSphere(badan.getPos().X, badan.getPos().Y + badan.getrady() / 4, badan.getPos().Z + badan.getradz() / 1.5f, badan.getradx() / 2.5f, badan.getrady() / 4f, badan.getradz() / 2f, 1000, 1000);
            mata.load(sizeX, sizeY);

            kornea.createSphere(mata.getPos().X, mata.getPos().Y, mata.getPos().Z + mata.getradz() / 1.25f, mata.getradx() / 3f, mata.getrady() / 3f, mata.getradz() / 3f, 1000, 1000);
            kornea.load(sizeX, sizeY);

            kaki1.createCone(badan.getPos().X - badan.getradx() / 2, badan.getPos().Y - badan.getrady() / 1.5f, badan.getPos().Z, badan.getradx() / 5, badan.getrady() / 1.5f, 10000);
            kaki1.load(sizeX, sizeY);
            kaki1.rotatecenter(180, 'z');

            kaki2.createCone(badan.getPos().X + badan.getradx() / 2, badan.getPos().Y - badan.getrady() / 1.5f, badan.getPos().Z, badan.getradx() / 5, badan.getrady() / 1.5f, 10000);
            kaki2.load(sizeX, sizeY);
            kaki2.rotatecenter(180, 'z');

            tangan1.createCone(badan.getPos().X - badan.getradx() / 1.5f, badan.getPos().Y, badan.getPos().Z, badan.getradx() / 5, badan.getrady() * 0.75f, 10000);
            tangan1.load(sizeX, sizeY);
            tangan1.rotatecenter(45, 'z');

            tangan2.createCone(badan.getPos().X + badan.getradx() / 1.5f, badan.getPos().Y, badan.getPos().Z, badan.getradx() / 5, badan.getrady() * 0.75f, 10000);
            tangan2.load(sizeX, sizeY);
            tangan2.rotatecenter(-45, 'z');

            antena1.createCube(badan.getPos().X - badan.getradx() / 1.5f, badan.getPos().Y + badan.getrady(), badan.getPos().Z, badan.getradx() / 10, badan.getrady() * 0.75f, badan.getradz() / 10);
            antena1.load(sizeX, sizeY);
            antena1.rotatecenter(30, 'z');

            antena2.createCube(badan.getPos().X + badan.getradx() / 1.5f, badan.getPos().Y + badan.getrady(), badan.getPos().Z, badan.getradx() / 10, badan.getrady() * 0.75f, badan.getradz() / 10);
            antena2.load(sizeX, sizeY);
            antena2.rotatecenter(-30, 'z');

            alis.createCube(mata.getPos().X, mata.getPos().Y + mata.getrady() * 0.85f, mata.getPos().Z + mata.getrady() * 0.25f, mata.getradx() * 1.75f, mata.getrady() / 3f, mata.getradz());
            alis.load(sizeX, sizeY);

            mulut.createEllipsoidVertices(badan.getPos().X, badan.getPos().Y - badan.getrady() / 4.5f, badan.getPos().Z + badan.getradz() / 1.05f, badan.getradx() / 30, badan.getrady() / 2, 0f, 0.5f);
            mulut.load(sizeX, sizeY);
            mulut.rotatecenter(90, 'x');
            mulut.rotatecenter(180, 'y');
            mulut.rotatecenter(90, 'z');
        }

        public void render(Camera _camera)
        {
            badan.CameraMovement(_camera);
            badan.render();

            mata.CameraMovement(_camera);
            mata.render();

            kornea.CameraMovement(_camera);
            kornea.render();

            kaki1.CameraMovement(_camera);
            kaki1.render();

            kaki2.CameraMovement(_camera);
            kaki2.render();

            tangan1.CameraMovement(_camera);
            tangan1.render();

            tangan2.CameraMovement(_camera);
            tangan2.render();

            antena1.CameraMovement(_camera);
            antena1.render();

            antena2.CameraMovement(_camera);
            antena2.render();

            alis.CameraMovement(_camera);
            alis.render();

            mulut.CameraMovement(_camera);
            mulut.render();
        }

        public void rotate(float angle, char x)
        {
            badan.rotate(angle, x);
            mata.rotate(angle, x);
            kornea.rotate(angle, x);
            kaki1.rotate(angle, x);
            kaki2.rotate(angle, x);
            tangan1.rotate(angle, x);
            tangan2.rotate(angle, x);
            antena1.rotate(angle, x);
            antena2.rotate(angle, x);
            alis.rotate(angle, x);
            mulut.rotate(angle, x);
        }

        public void scale(float m)
        {
            badan.scale(m);
            mata.scale(m);
            kornea.scale(m);
            kaki1.scale(m);
            kaki2.scale(m);
            tangan1.scale(m);
            tangan2.scale(m);
            antena1.scale(m);
            antena2.scale(m);
            alis.scale(m);
            mulut.scale(m);
        }

        public void translateup()
        {
            badan.translateup();
            mata.translateup();
            kornea.translateup();
            kaki1.translateup();
            kaki2.translateup();
            tangan1.translateup();
            tangan2.translateup();
            antena1.translateup();
            antena2.translateup();
            alis.translateup();
            mulut.translateup();
        }

        public void translatedown()
        {
            badan.translatedown();
            mata.translatedown();
            kornea.translatedown();
            kaki1.translatedown();
            kaki2.translatedown();
            tangan1.translatedown();
            tangan2.translatedown();
            antena1.translatedown();
            antena2.translatedown();
            alis.translatedown();
            mulut.translatedown();
        }

        public void translatefront()
        {
            badan.translatefront();
            mata.translatefront();
            kornea.translatefront();
            kaki1.translatefront();
            kaki2.translatefront();
            tangan1.translatefront();
            tangan2.translatefront();
            antena1.translatefront();
            antena2.translatefront();
            alis.translatefront();
            mulut.translatefront();
        }

        public void translateback()
        {
            badan.translateback();
            mata.translateback();
            kornea.translateback();
            kaki1.translateback();
            kaki2.translateback();
            tangan1.translateback();
            tangan2.translateback();
            antena1.translateback();
            antena2.translateback();
            alis.translateback();
            mulut.translateback();
        }

        public void translateright()
        {
            badan.translateright();
            mata.translateright();
            kornea.translateright();
            kaki1.translateright();
            kaki2.translateright();
            tangan1.translateright();
            tangan2.translateright();
            antena1.translateright();
            antena2.translateright();
            alis.translateright();
            mulut.translateright();
        }

        public void translateleft()
        {
            badan.translateleft();
            mata.translateleft();
            kornea.translateleft();
            kaki1.translateleft();
            kaki2.translateleft();
            tangan1.translateleft();
            tangan2.translateleft();
            antena1.translateleft();
            antena2.translateleft();
            alis.translateleft();
            mulut.translateleft();
        }

        public void animate(double time)
        {
            badan.animation(time);
            mata.animation(time);
            kornea.animation(time);
            kaki1.animation(time);
            kaki2.animation(time);
            tangan1.animation(time);
            tangan2.animation(time);
            antena1.animation(time);
            antena2.animation(time);
            alis.animation(time);
            mulut.animation(time);
        }
    }
}
