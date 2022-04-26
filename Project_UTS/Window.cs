using OpenTK.Graphics.OpenGL4;
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
        Camera _camera;

        Spongebob spongebob = new Spongebob(0f, 0f, -5f);
        Patrick patrick = new Patrick(5f, -0.03f, -5f);
        Plankton plankton = new Plankton(10f, -7.72f, -20f);
        Ground ground = new Ground(5f, -3.6f, -5f);

        Vector3 spongebobpos, patrickpos, planktonpos;

        String choice = "Spongebob";

        bool animation = false;

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
            //time = RenderTime;
            //deltaTime = 0;
        }

        protected override void OnLoad()
        {
            GL.ClearColor(0.58f, 0.84f, 0.98f, 0.8f);
            GL.Enable(EnableCap.DepthTest);

            plankton.load(Size.X, Size.Y);
            spongebob.load(Size.X, Size.Y);
            patrick.load(Size.X, Size.Y);
            ground.load(Size.X, Size.Y);

            plankton.scale(0.5f);
            spongebob.scale(5f);
            patrick.scale(5f);
            ground.scale(5f);

            _camera = new Camera(new Vector3(3.0f, 3.0f, 3.0f), Size.X / (float)Size.Y);

            base.OnLoad();
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            float time = (float)args.Time;
            time += 10.0f * (float)args.Time;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            /*foreach (Balok i in objectList)
            {
                i.render(time);

                *//*i.rotate(Vector3.Zero, Vector3.UnitY, 45 * time);
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);
                }*//*
            }*/

            if (animation)
            {
                if (choice == "Spongebob")
                {
                    spongebob.animate(time, 30f, 'x', spongebobpos);
                }
                else if (choice == "Patrick")
                {
                    patrick.animate(time, 30f, 'x', patrickpos);
                }
                else if (choice == "Plankton")
                {
                    plankton.animate();
                }
            }

            spongebobpos = new Vector3(spongebob.getPos());
            spongebobpos.Z *= -5;
            spongebobpos.Y -= 30;

            patrickpos = new Vector3(patrick.getPos());
            patrickpos.Z *= -5;
            patrickpos.Y -= 30;

            planktonpos = new Vector3(patrick.getPos());
            planktonpos.Z *= -5;
            planktonpos.Y -= 25;

            spongebob.render(_camera);
            patrick.render(_camera);
            plankton.render(_camera);
            ground.render(_camera);

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
            float angle = 5f;

            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad4))
            {
                rotate(angle, 'y');

            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad6))
            {
                rotate(-angle, 'y');

            }

            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad8))
            {
                rotate(angle, 'x');

            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad2))
            {
                rotate(-angle, 'x');
            }

            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad7))
            {
                rotate(angle, 'z');
            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.KeyPad9))
            {
                rotate(-angle, 'z');
            }

            float m = 0.05f;
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.Up))
            {
                Scale(m);
            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.Down))
            {
                Scale(-m);
            }

            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.P))
            {
                if (animation == false)
                {
                    animation = true;
                }
                else
                {
                    animation = false;
                }
            }

            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.D1))
            {
                choice = "Spongebob";
            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.D2))
            {
                choice = "Patrick";
            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.D3))
            {
                choice = "Plankton";
            }


            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.Y))
            {
                if(choice == "Spongebob")
                {
                    spongebob.translateup();
                }
                else if(choice == "Patrick")
                {
                    patrick.translateup();
                }
                else if(choice == "Plankton")
                {
                    plankton.translateup();
                }
            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.I))
            {
                if (choice == "Spongebob")
                {
                    spongebob.translatedown();
                }
                else if (choice == "Patrick")
                {
                    patrick.translatedown();
                }
                else if (choice == "Plankton")
                {
                    plankton.translatedown();
                }
            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.U))
            {
                if (choice == "Spongebob")
                {
                    spongebob.translatefront();
                }
                else if (choice == "Patrick")
                {
                    patrick.translatefront();
                }
                else if (choice == "Plankton")
                {
                    plankton.translatefront();
                }
            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.J))
            {
                if (choice == "Spongebob")
                {
                    spongebob.translateback();
                }
                else if (choice == "Patrick")
                {
                    patrick.translateback();
                }
                else if (choice == "Plankton")
                {
                    plankton.translateback();
                }
            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.K))
            {
                if (choice == "Spongebob")
                {
                    spongebob.translateright();
                }
                else if (choice == "Patrick")
                {
                    patrick.translateright();
                }
                else if (choice == "Plankton")
                {
                    plankton.translateright();
                }
            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.H))
            {
                if (choice == "Spongebob")
                {
                    spongebob.translateleft();
                }
                else if (choice == "Patrick")
                {
                    patrick.translateleft();
                }
                else if (choice == "Plankton")
                {
                    plankton.translateleft();
                }
            }
            if (KeyboardState.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.B))
            {
                spongebob.rotatepoint(30f, 'x', spongebobpos);
                Console.WriteLine(spongebobpos);
                //spongebob.translateback();

            }
        }

        protected void CameraMovement()
        {
            var input = KeyboardState;
            const float camera_speed = 20f;

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

        protected void Scale(float m)
        {
            spongebob.scale(m);
            patrick.scale(m);
            plankton.scale(m);
        }

        protected void rotate(float angle, char x)
        {
            spongebob.rotate(angle, x);
            patrick.rotate(angle, x);
            plankton.rotate(angle, x);
        }
    }
}