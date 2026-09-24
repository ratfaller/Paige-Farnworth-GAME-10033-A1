// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        
        

        public void Setup()
        {
            Window.SetTitle("Interactive Lightbulb");
            Window.SetSize(400, 400);
            Draw.SetLineSize(10);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(50, 50, 50);
            //draw a lightbulb
            Draw.Line(100, 0, 100, 250);
            Draw.Ellipse(100, 250, 80, 100);

            

            //Change background and light colour
            if (Input.IsKeyboardKeyReleased(KeyboardKey.Down) == true )
            {
                //Makes the background bright
                Window.ClearBackground(220, 220, 220);
                ///Makes the lightbulb yellow
                Draw.SetFillColor(255, 255, 125);
            }
            else
            {
                //Makes the lightbulb black
                Draw.SetFillColor(0, 0, 0);
            }

            //tug the cord down
            if (Input.IsKeyboardKeyDown(KeyboardKey.Down) == true )
            {
                Draw.Line(300, 0, 300, 350);
                Draw.Ellipse(300, 350, 20, 40);
            }
            else
            {
                Draw.Line(300, 0, 300, 300);
                Draw.Ellipse(300, 300, 20, 40);
            }
            

        }
    }

}
