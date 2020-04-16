using Microsoft.Graphics.Canvas;
using Windows.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Tetris
{
    //Source https://github.com/EricCharnesky/CIS297-Winter2020/blob/master/PongExample/PongExample/Rectangle.cs
    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Windows.UI.Color Color { get; set; }

        public void Draw(CanvasDrawingSession drawingSession)
        {
            drawingSession.DrawRectangle(X, Y, Width, Height, Color);
        }
    }
}
