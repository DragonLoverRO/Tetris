﻿using Microsoft.Graphics.Canvas;
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
        private Rectangle LeftWall;
        private Rectangle RightWall;
        private Rectangle BottomWall;
        private Rectangle TopWall;
        private TetrisPiece piece1;
        private TetrisPiece piece2;
        private TetrisPiece piece3;
        private TetrisPiece piece4;
        private CanvasDrawingSession drawingSession;

        public Tetris(CanvasDrawingSession drawingSession)
        {
            LeftWall = new Rectangle
            {
                x = 10,
                y = 40,
                width = 10,
                height = 500,
                color = Colors.White
            };

            RightWall = new Rectangle
            {
                x = 220,
                y = 40,
                width = 10,
                height = 500,
                color = Colors.White
            };

            BottomWall = new Rectangle
            {
                x = 10,
                y = 530,
                width = 220,
                height = 10,
                color = Colors.White
            };

            TopWall = new Rectangle
            {
                x = 10,
                y = 40,
                width = 220,
                height = 10,
                color = Colors.White
            };

            this.drawingSession = drawingSession;
            LeftWall.Draw(drawingSession);
            RightWall.Draw(drawingSession);
            TopWall.Draw(drawingSession);
            BottomWall.Draw(drawingSession);
        }

        public void create_O_Piece(CanvasDrawingSession drawingSession)
        {
            piece1 = new TetrisPiece
            {
                x = 100,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Yellow
            };

            piece2 = new TetrisPiece
            {
                x = 120,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Yellow
            };

            piece3 = new TetrisPiece
            {
                x = 100,
                y = 70,
                width = 20,
                height = 20,
                color = Colors.Yellow
            };

            piece4 = new TetrisPiece
            {
                x = 120,
                y = 70,
                width = 20,
                height = 20,
                color = Colors.Yellow
            };

            this.drawingSession = drawingSession;
            piece1.Draw(drawingSession);
            piece2.Draw(drawingSession);
            piece3.Draw(drawingSession);
            piece4.Draw(drawingSession);
        }

        public void create_I_Piece(CanvasDrawingSession drawingSession)
        {
            piece1 = new TetrisPiece
            {
                x = 100,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Cyan
            };

            piece2 = new TetrisPiece
            {
                x = 100,
                y = 70,
                width = 20,
                height = 20,
                color = Colors.Cyan
            };

            piece3 = new TetrisPiece
            {
                x = 100,
                y = 90,
                width = 20,
                height = 20,
                color = Colors.Cyan
            };

            piece4 = new TetrisPiece
            {
                x = 100,
                y = 110,
                width = 20,
                height = 20,
                color = Colors.Cyan
            };

            this.drawingSession = drawingSession;
            piece1.Draw(drawingSession);
            piece2.Draw(drawingSession);
            piece3.Draw(drawingSession);
            piece4.Draw(drawingSession);
        }

        public void create_S_Piece(CanvasDrawingSession drawingSession)
        {
            piece1 = new TetrisPiece
            {
                x = 100,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Red
            };

            piece2 = new TetrisPiece
            {
                x = 120,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Red
            };

            piece3 = new TetrisPiece
            {
                x = 100,
                y = 70,
                width = 20,
                height = 20,
                color = Colors.Red
            };

            piece4 = new TetrisPiece
            {
                x = 80,
                y = 70,
                width = 20,
                height = 20,
                color = Colors.Red
            };

            this.drawingSession = drawingSession;
            piece1.Draw(drawingSession);
            piece2.Draw(drawingSession);
            piece3.Draw(drawingSession);
            piece4.Draw(drawingSession);
        }

        public void create_Z_Piece(CanvasDrawingSession drawingSession)
        {
            piece1 = new TetrisPiece
            {
                x = 100,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Green
            };

            piece2 = new TetrisPiece
            {
                x = 120,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Green
            };

            piece3 = new TetrisPiece
            {
                x = 120,
                y = 70,
                width = 20,
                height = 20,
                color = Colors.Green
            };

            piece4 = new TetrisPiece
            {
                x = 140,
                y = 70,
                width = 20,
                height = 20,
                color = Colors.Green
            };

            this.drawingSession = drawingSession;
            piece1.Draw(drawingSession);
            piece2.Draw(drawingSession);
            piece3.Draw(drawingSession);
            piece4.Draw(drawingSession);
        }

        public void create_L_Piece(CanvasDrawingSession drawingSession)
        {
            piece1 = new TetrisPiece
            {
                x = 100,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Orange
            };

            piece2 = new TetrisPiece
            {
                x = 100,
                y = 70,
                width = 20,
                height = 20,
                color = Colors.Orange
            };

            piece3 = new TetrisPiece
            {
                x = 100,
                y = 90,
                width = 20,
                height = 20,
                color = Colors.Orange
            };

            piece4 = new TetrisPiece
            {
                x = 120,
                y = 90,
                width = 20,
                height = 20,
                color = Colors.Orange
            };

            this.drawingSession = drawingSession;
            piece1.Draw(drawingSession);
            piece2.Draw(drawingSession);
            piece3.Draw(drawingSession);
            piece4.Draw(drawingSession);
        }

        public void create_J_Piece(CanvasDrawingSession drawingSession)
        {
            piece1 = new TetrisPiece
            {
                x = 100,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Pink
            };

            piece2 = new TetrisPiece
            {
                x = 100,
                y = 70,
                width = 20,
                height = 20,
                color = Colors.Pink
            };

            piece3 = new TetrisPiece
            {
                x = 100,
                y = 90,
                width = 20,
                height = 20,
                color = Colors.Pink
            };

            piece4 = new TetrisPiece
            {
                x = 80,
                y = 90,
                width = 20,
                height = 20,
                color = Colors.Pink
            };

            this.drawingSession = drawingSession;
            piece1.Draw(drawingSession);
            piece2.Draw(drawingSession);
            piece3.Draw(drawingSession);
            piece4.Draw(drawingSession);
        }

        public void create_T_Piece(CanvasDrawingSession drawingSession)
        {
            piece1 = new TetrisPiece
            {
                x = 100,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Purple
            };

            piece2 = new TetrisPiece
            {
                x = 120,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Purple
            };

            piece3 = new TetrisPiece
            {
                x = 80,
                y = 50,
                width = 20,
                height = 20,
                color = Colors.Purple
            };

            piece4 = new TetrisPiece
            {
                x = 100,
                y = 70,
                width = 20,
                height = 20,
                color = Colors.Purple
            };

            this.drawingSession = drawingSession;
            piece1.Draw(drawingSession);
            piece2.Draw(drawingSession);
            piece3.Draw(drawingSession);
            piece4.Draw(drawingSession);
        }

        public void MoveTetrisPiece(int changeIntX)
        {
            piece1.x += changeIntX;
            piece2.x += changeIntX;
            piece3.x += changeIntX;
            piece4.x += changeIntX;
        }
    }
}