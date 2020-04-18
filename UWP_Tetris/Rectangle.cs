using Microsoft.Graphics.Canvas;
using Windows.UI;

namespace UWP_Tetris
{
    //source: https://github.com/EricCharnesky/CIS297-Winter2020/tree/master/PongExample
    public class Rectangle
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Color color { get; set; }

        public void Draw(CanvasDrawingSession drawingSession)
        {
            drawingSession.DrawRectangle(x, y, width, height, color);
        }
    }
}