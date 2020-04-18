using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace UWP_Tetris
{
    //source: https://github.com/EricCharnesky/CIS297-Winter2020/tree/master/PongExample
    public class Tetris
    {
        private Wall LeftWall;
        private Wall RightWall;
        private Wall BottomWall;
        private Wall TopWall;
        private CanvasDrawingSession drawingSession;

        public Tetris(CanvasDrawingSession drawingSession)
        {
            LeftWall = new Wall
            {
                x = 10,
                y = 40,
                width = 10,
                height = 500,
                color = Colors.Red
            };

            RightWall = new Wall
            {
                x = 220,
                y = 40,
                width = 10,
                height = 500,
                color = Colors.Red
            };

            BottomWall = new Wall
            {
                x = 10,
                y = 530,
                width = 220,
                height = 10,
                color = Colors.Red
            };

            TopWall = new Wall
            {
                x = 10,
                y = 40,
                width = 220,
                height = 10,
                color = Colors.Red
            };

            this.drawingSession = drawingSession;
            LeftWall.Draw(drawingSession);
            RightWall.Draw(drawingSession);
            TopWall.Draw(drawingSession);
            BottomWall.Draw(drawingSession);
        }
    }
}
