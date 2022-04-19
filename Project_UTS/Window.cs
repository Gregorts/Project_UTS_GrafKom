﻿using OpenTK.Graphics.OpenGL4;
using LearnOpenTK.Common;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UTS
{
    internal class Window : GameWindow
    {
        //List<Balok> objectList = new List<Balok>();
        double time;

        Camera _camera;

        Spongebob spongebob = new Spongebob();
        Patrick patrick = new Patrick();

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
        }

        protected override void OnLoad()
        {
            GL.ClearColor(0.5f, 0.5f, 0.5f, 1.0f);
            GL.Enable(EnableCap.DepthTest);

            /*var cube1 = new Balok(new Vector3(1.0f, 0.9f, 0.4f));
            cube1.createCuboid(0, 0, 0.5f, 2.5f, 3, 1.5f); //sama dengan createBoxVertices
            objectList.Add(cube1);*/

            /*var elipse1 = new Asset3d(new Vector3(0.1f, 0.5f, 0));
            elipse1.createEllipsoid(0, 0, 0, 0.5f, 0.5f, 0.5f);
            objectList.Add(elipse1);*/

            //var halfelipse1 = new Asset3d(new Vector3(1, 1, 1));
            //halfelipse1.createHalfEllipsoid(0.5f, 0.5f, 0, 0.4f, 0.4f, 0.4f);
            //objectList.Add(halfelipse1);

            //var halfelipse2 = new Asset3d(new Vector3(1, 1, 1));
            //halfelipse1.createHalfEllipsoid(-0.5f, 0.5f, 0, 0.4f, 0.4f, 0.4f);
            //objectList.Add(halfelipse1);

            /*foreach (Balok i in objectList)
            {
                i.load(Size.X, Size.Y);
                //i.rotate();
            }*/
            spongebob.load(Size.X, Size.Y);
            patrick.load(Size.X, Size.Y);

            _camera = new Camera(new Vector3(3.0f, 3.0f, 3.0f), Size.X / (float)Size.Y);

            base.OnLoad();
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            float time = (float)args.Time; //Deltatime ==> waktu antara frame sebelumnya ke frame berikutnya, gunakan untuk animasi

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); // DepthBufferBit juga harus di clear karena kita memakai depth testing.

            time += 7.0f * (float)args.Time;

            /*foreach (Balok i in objectList)
            {
                i.render(time);

                *//*i.rotate(Vector3.Zero, Vector3.UnitY, 45 * time);
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);
                }*//*
            }*/

            spongebob.render(_camera, time);
            //patrick.render(time);

            SwapBuffers();
            base.OnRenderFrame(args);
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            KeyPress();
            CameraMovement();

            base.OnUpdateFrame(args);
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Size.X, Size.Y);
            base.OnResize(e);
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            _camera.Fov -= e.OffsetY;
            base.OnMouseWheel(e);
        }

        protected void KeyPress()
        {
            
        }

        protected void CameraMovement()
        {
            var input = KeyboardState;
            const float camera_speed = 2.5f;

            if (!IsFocused) //Reject semua input saat window bukan focus.
            {
                return;
            }
            
            if (input.IsKeyDown(Keys.Escape))
            {
                Close();
            }
            if (input.IsKeyDown(Keys.W))
            {
                _camera.Position += _camera.Front * camera_speed * (float)RenderTime; // Forward
            }

            if (input.IsKeyDown(Keys.S))
            {
                _camera.Position -= _camera.Front * camera_speed * (float)RenderTime; // Backwards
            }
            if (input.IsKeyDown(Keys.A))
            {
                _camera.Position -= _camera.Right * camera_speed * (float)RenderTime; // Left
            }
            if (input.IsKeyDown(Keys.D))
            {
                _camera.Position += _camera.Right * camera_speed * (float)RenderTime; // Right
            }
            if (input.IsKeyDown(Keys.Space))
            {
                _camera.Position += _camera.Up * camera_speed * (float)RenderTime; // Up
            }
            if (input.IsKeyDown(Keys.LeftShift))
            {
                _camera.Position -= _camera.Up * camera_speed * (float)RenderTime; // Down
            }
        }
    }
}
