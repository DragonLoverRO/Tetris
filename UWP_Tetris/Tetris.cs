using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Tetris
{
    public class Tetris
    {
        private Wall LeftWall;
        private Wall RightWall;
        private Wall BottomWall;
        private Wall TopWall;
        private CanvasDrawingSession drawingSession;

        public Tetris(CanvasDrawingSession drawingSession)
        {
            this.drawingSession = drawingSession;
        }
    }
}
