using OpenTK.Graphics.OpenGL4;
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

        Spongebob spongebob = new Spongebob();
        Patrick patrick = new Patrick();

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
        }

        protected override void OnLoad()
        {
            base.OnLoad();

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
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);

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
            //spongebob.render(time);
            patrick.render(time);
            SwapBuffers();
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);

            float time = (float)args.Time; //Deltatime ==> waktu antara frame sebelumnya ke frame berikutnya, gunakan untuk animasi

            if (!IsFocused)
            {
                return; //Reject semua input saat window bukan focus.
            }

            var input = KeyboardState;

            if (input.IsKeyDown(Keys.Escape))
            {
                Close();
            }
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Size.X, Size.Y);
        }
    }
}
