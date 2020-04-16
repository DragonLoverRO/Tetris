using Microsoft.Graphics.Canvas;
using Windows.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Tetris
{
    //Source:https://github.com/EricCharnesky/CIS297-Winter2020/blob/master/PongExample/PongExample/Ball.cs
    public class Tetris_Piece
    {
        public CanvasBitmap ballImage;
        public bool movingLeftward { get; set; }
        public bool movingDownward { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }

        public int Speed { get; set; }
        public void Draw(CanvasDrawingSession drawingSession)
        {
            if (ballImage != null)
            {
                drawingSession.DrawImage(ballImage, X, Y);
            }

        }

        public void updatePosition()
        {
            if (movingLeftward)
            {
                X -= Speed;
            }
            else
            {
                X += Speed;
            }
            if (movingDownward)
            {
                Y += Speed;
            }
            else
            {
                Y -= Speed;
            }
        }

        public void ChangeColor()
        {
            Random random = new Random();
            Color = Color.FromArgb(255, (byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
        }
    }
}
