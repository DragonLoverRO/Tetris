using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.UI.Xaml;
using Windows.UI;

namespace UWP_Tetris
{
    //sources: https://github.com/EricCharnesky/CIS297-Winter2020/tree/master/PongExample/PongExample
    public class TetrisPiece : Rectangle
    {
        public void moveDownward()
        {
            y += 20;
        }
        public void DrawTetrisPiece(CanvasDrawingSession drawingSession)
        {
            drawingSession.FillRectangle(x, y, width, height, color);
            drawingSession.DrawRectangle(x, y, width, height, Colors.Gray);
        }
    }
}