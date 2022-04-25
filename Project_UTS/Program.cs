using System;
using LearnOpenTK.Common;
using OpenTK.Windowing.Desktop;

namespace Project_UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            var _NativeWindowSetting = new NativeWindowSettings()
            {
                Size = new OpenTK.Mathematics.Vector2i(1920, 1080),
                Title = "Project UTS GrafKom"
            };

            using (var _Window= new Window(GameWindowSettings.Default, _NativeWindowSetting))
            {
                _Window.Run();
            }
        }
    }
}