using System;

namespace PathFindingDemo
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
           Form_Main form_Main = new Form_Main();
           form_Main.Show();
           form_Main.pathFindingDemo = new PathFindingDemo(form_Main.pictureBox1.Handle, form_Main, form_Main.pictureBox1);
           form_Main.Init();
           form_Main.pathFindingDemo.Run();
        }
    }
#endif
}

