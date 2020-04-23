﻿using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private TetrisPiece[,] tetrisBoard = new TetrisPiece[10,24];
        private Random rnd = new Random();
        private int Rotate = 4;
        private int CurrentPieceMade;
        private int moveingDown;
        private int piece1XCordinate;
        private int piece1YCordinate;
        private int piece2XCordinate;
        private int piece2YCordinate;
        private int piece3XCordinate;
        private int piece3YCordinate;
        private int piece4XCordinate;
        private int piece4YCordinate;
        public bool gameOver { get; private set; }
        private bool isUserPieceMovingLeftward;
        private bool notAtBottom;
        public Tetris()
        {
            gameOver = false;
            notAtBottom = false;
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
        }

        public void setPiece()
        {
            //int CreatePiece = rnd.Next(7);
            int CreatePiece = 3;
            Rotate = 4;
            CurrentPieceMade = CreatePiece;
            moveingDown = 0;
            //O piece
            if (CreatePiece == 0)
            {
                piece1XCordinate = 4;
                piece1YCordinate = 0;
                piece2XCordinate = 5;
                piece2YCordinate = 0;
                piece3XCordinate = 5;
                piece3YCordinate = 1;
                piece4XCordinate = 4;
                piece4YCordinate = 1;

                tetrisBoard[piece1XCordinate, piece1YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Yellow
                };
                tetrisBoard[piece2XCordinate, piece2YCordinate] = new TetrisPiece
                {
                    x = 120,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Yellow
                };
                tetrisBoard[piece3XCordinate, piece3YCordinate] = new TetrisPiece
                {
                    x = 120,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Yellow
                };
                tetrisBoard[piece4XCordinate, piece4YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Yellow
                };
            }
            //I Piece
            else if (CreatePiece == 1)
            {
                piece1XCordinate = 4;
                piece1YCordinate = 0;
                piece2XCordinate = 4;
                piece2YCordinate = 1;
                piece3XCordinate = 4;
                piece3YCordinate = 2;
                piece4XCordinate = 4;
                piece4YCordinate = 3;

                tetrisBoard[piece1XCordinate, piece1YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Cyan
                };
                tetrisBoard[piece2XCordinate, piece2YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Cyan
                };
                tetrisBoard[piece3XCordinate, piece3YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 90,
                    width = 20,
                    height = 20,
                    color = Colors.Cyan
                };
                tetrisBoard[piece4XCordinate, piece4YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 110,
                    width = 20,
                    height = 20,
                    color = Colors.Cyan
                };
            }
            //S Piece
            else if (CreatePiece == 2)
            {
                piece1XCordinate = 3;
                piece1YCordinate = 1;
                piece2XCordinate = 4;
                piece2YCordinate = 1;
                piece3XCordinate = 4;
                piece3YCordinate = 0;
                piece4XCordinate = 5;
                piece4YCordinate = 0;

                tetrisBoard[piece1XCordinate, piece1YCordinate] = new TetrisPiece
                {
                    x = 80,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Red
                };
                tetrisBoard[piece2XCordinate, piece2YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Red
                };

                tetrisBoard[piece3XCordinate, piece3YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Red
                };
                tetrisBoard[piece4XCordinate, piece4YCordinate] = new TetrisPiece
                {
                    x = 120,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Red
                };
            }
            //Z Piece
            else if (CreatePiece == 3)
            {
                piece1XCordinate = 4;
                piece1YCordinate = 0;
                piece2XCordinate = 5;
                piece2YCordinate = 0;
                piece3XCordinate = 5;
                piece3YCordinate = 1;
                piece4XCordinate = 6;
                piece4YCordinate = 1;

                tetrisBoard[piece1XCordinate, piece1YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Green
                };
                tetrisBoard[piece2XCordinate, piece2YCordinate] = new TetrisPiece
                {
                    x = 120,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Green
                };
                tetrisBoard[piece3XCordinate, piece3YCordinate] = new TetrisPiece
                {
                    x = 120,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Green
                };
                tetrisBoard[piece4XCordinate, piece4YCordinate] = new TetrisPiece
                {
                    x = 140,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Green
                };

            }
            //L Piece
            else if (CreatePiece == 4)
            {
                piece1XCordinate = 4;
                piece1YCordinate = 0;
                piece2XCordinate = 4;
                piece2YCordinate = 1;
                piece3XCordinate = 4;
                piece3YCordinate = 2;
                piece4XCordinate = 5;
                piece4YCordinate = 2;

                tetrisBoard[piece1XCordinate, piece1YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Orange
                };
                tetrisBoard[piece2XCordinate, piece2YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Orange
                };
                tetrisBoard[piece3XCordinate, piece3YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 90,
                    width = 20,
                    height = 20,
                    color = Colors.Orange
                };
                tetrisBoard[piece4XCordinate, piece4YCordinate] = new TetrisPiece
                {
                    x = 120,
                    y = 90,
                    width = 20,
                    height = 20,
                    color = Colors.Orange
                };
            }
            //J Piece
            else if (CreatePiece == 5)
            {
                piece1XCordinate = 4;
                piece1YCordinate = 0;
                piece2XCordinate = 4;
                piece2YCordinate = 1;
                piece3XCordinate = 4;
                piece3YCordinate = 2;
                piece4XCordinate = 3;
                piece4YCordinate = 2;

                tetrisBoard[piece1XCordinate, piece1YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Pink
                };
                tetrisBoard[piece2XCordinate, piece2YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Pink
                };
                tetrisBoard[piece3XCordinate, piece3YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 90,
                    width = 20,
                    height = 20,
                    color = Colors.Pink
                };
                tetrisBoard[piece4XCordinate, piece4YCordinate] = new TetrisPiece
                {
                    x = 80,
                    y = 90,
                    width = 20,
                    height = 20,
                    color = Colors.Pink
                };
            }
            // T piece
            else if (CreatePiece == 6)
            {
                piece1XCordinate = 3;
                piece1YCordinate = 0;
                piece2XCordinate = 4;
                piece2YCordinate = 0;
                piece3XCordinate = 5;
                piece3YCordinate = 0;
                piece4XCordinate = 4;
                piece4YCordinate = 1;

                tetrisBoard[piece1XCordinate, piece1YCordinate] = new TetrisPiece
                {
                    x = 80,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Purple
                };
                tetrisBoard[piece2XCordinate, piece2YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Purple
                };
                tetrisBoard[piece3XCordinate, piece3YCordinate] = new TetrisPiece
                {
                    x = 120,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Purple
                };
                tetrisBoard[piece4XCordinate, piece4YCordinate] = new TetrisPiece
                {
                    x = 100,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Purple
                };
            }
        }

        

        public void drawScreen(CanvasDrawingSession drawingSession)
        {
            LeftWall.Draw(drawingSession);
            RightWall.Draw(drawingSession);
            TopWall.Draw(drawingSession);
            BottomWall.Draw(drawingSession);
        }

        public void DrawPiece(CanvasDrawingSession drawingSession)
        {
            tetrisBoard[piece1XCordinate, piece1YCordinate].Draw(drawingSession);
            tetrisBoard[piece2XCordinate, piece2YCordinate].Draw(drawingSession);
            tetrisBoard[piece3XCordinate, piece3YCordinate].Draw(drawingSession);
            tetrisBoard[piece4XCordinate, piece4YCordinate].Draw(drawingSession);
        }

        public void MoveTetrisPiece(int changeIntX)
        {
            if (changeIntX == -20)
            {
                isUserPieceMovingLeftward = true;
            }
            else
            {
                isUserPieceMovingLeftward = false;
            }

            if (isUserPieceMovingLeftward)
            {
                if (tetrisBoard[piece1XCordinate, piece1YCordinate].x - 20 >= LeftWall.x + 10 
                    && tetrisBoard[piece2XCordinate, piece2YCordinate].x - 20 >= LeftWall.x + 10 
                    && tetrisBoard[piece3XCordinate, piece3YCordinate].x - 20 >= LeftWall.x + 10 
                    && tetrisBoard[piece4XCordinate, piece4YCordinate].x - 20 >= LeftWall.x + 10)
                {
                    tetrisBoard[piece1XCordinate, piece1YCordinate].x += changeIntX;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += changeIntX;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += changeIntX;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += changeIntX;

                    piece1 = tetrisBoard[piece1XCordinate, piece1YCordinate];
                    piece2 = tetrisBoard[piece2XCordinate, piece2YCordinate];
                    piece3 = tetrisBoard[piece3XCordinate, piece3YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = null;
                    tetrisBoard[piece2XCordinate, piece2YCordinate] = null;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece1XCordinate--;
                    piece2XCordinate--;
                    piece3XCordinate--;
                    piece4XCordinate--;

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = piece1;
                    tetrisBoard[piece2XCordinate, piece2YCordinate] = piece2;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = piece3;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece1 = null;
                    piece2 = null;
                    piece3 = null;
                    piece4 = null;
                }
            }
            else
            {
                if (tetrisBoard[piece1XCordinate, piece1YCordinate].x + 20 <= RightWall.x - 10 
                    && tetrisBoard[piece2XCordinate, piece2YCordinate].x + 20 <= RightWall.x - 10 
                    && tetrisBoard[piece3XCordinate, piece3YCordinate].x + 20 <= RightWall.x - 10 
                    && tetrisBoard[piece4XCordinate, piece4YCordinate].x + 20 <= RightWall.x - 10)
                {
                    tetrisBoard[piece1XCordinate, piece1YCordinate].x += changeIntX;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += changeIntX;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += changeIntX;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += changeIntX;

                    piece1 = tetrisBoard[piece1XCordinate, piece1YCordinate];
                    piece2 = tetrisBoard[piece2XCordinate, piece2YCordinate];
                    piece3 = tetrisBoard[piece3XCordinate, piece3YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = null;
                    tetrisBoard[piece2XCordinate, piece2YCordinate] = null;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece1XCordinate++;
                    piece2XCordinate++;
                    piece3XCordinate++;
                    piece4XCordinate++;

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = piece1;
                    tetrisBoard[piece2XCordinate, piece2YCordinate] = piece2;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = piece3;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece1 = null;
                    piece2 = null;
                    piece3 = null;
                    piece4 = null;
                }
            }
        }

        public void RotateTetrisPiece()
        {    // the boundries for the L shapes works testing completed 
            if (CurrentPieceMade == 1)
            {
                if (Rotate % 4 == 0 && tetrisBoard[piece1XCordinate, piece1YCordinate].x <= RightWall.x - 70)
                {
                    Rotate++;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += 20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].y += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += 40;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += -40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += 60;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -60;

                    piece2 = tetrisBoard[piece2XCordinate, piece2YCordinate];
                    piece3 = tetrisBoard[piece3XCordinate, piece3YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece2XCordinate, piece2YCordinate] = null;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece2XCordinate += 1;
                    piece2YCordinate -= 1;
                    piece3XCordinate += 2;
                    piece3YCordinate -= 2;
                    piece4XCordinate += 3;
                    piece4YCordinate -= 3;

                    tetrisBoard[piece2XCordinate, piece2YCordinate] = piece2;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = piece3;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece2 = null;
                    piece3 = null;
                    piece4 = null;
                }
                else if (Rotate % 4 == 1 && tetrisBoard[piece4XCordinate, piece4YCordinate].y <= BottomWall.y - 80)
                {
                    Rotate++;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += -20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].y += 20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += -40;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += 40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -60;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += 60;

                    piece2 = tetrisBoard[piece2XCordinate, piece2YCordinate];
                    piece3 = tetrisBoard[piece3XCordinate, piece3YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece2XCordinate, piece2YCordinate] = null;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece2XCordinate -= 1;
                    piece2YCordinate += 1;
                    piece3XCordinate -= 2;
                    piece3YCordinate += 2;
                    piece4XCordinate -= 3;
                    piece4YCordinate += 3;

                    tetrisBoard[piece2XCordinate, piece2YCordinate] = piece2;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = piece3;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece2 = null;
                    piece3 = null;
                    piece4 = null;
                }
                else if (Rotate % 4 == 2 && tetrisBoard[piece1XCordinate, piece1YCordinate].x <= RightWall.x - 70)
                {
                    Rotate++;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += 20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].y += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += 40;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += -40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += 60;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -60;

                    piece2 = tetrisBoard[piece2XCordinate, piece2YCordinate];
                    piece3 = tetrisBoard[piece3XCordinate, piece3YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece2XCordinate, piece2YCordinate] = null;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece2XCordinate += 1;
                    piece2YCordinate -= 1;
                    piece3XCordinate += 2;
                    piece3YCordinate -= 2;
                    piece4XCordinate += 3;
                    piece4YCordinate -= 3;

                    tetrisBoard[piece2XCordinate, piece2YCordinate] = piece2;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = piece3;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece2 = null;
                    piece3 = null;
                    piece4 = null;
                }
                else if (Rotate % 4 == 3 && tetrisBoard[piece4XCordinate, piece4YCordinate].y <= BottomWall.y - 80)
                {
                    Rotate++;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += -20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].y += 20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += -40;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += 40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -60;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += 60;

                    piece2 = tetrisBoard[piece2XCordinate, piece2YCordinate];
                    piece3 = tetrisBoard[piece3XCordinate, piece3YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece2XCordinate, piece2YCordinate] = null;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece2XCordinate -= 1;
                    piece2YCordinate += 1;
                    piece3XCordinate -= 2;
                    piece3YCordinate += 2;
                    piece4XCordinate -= 3;
                    piece4YCordinate += 3;

                    tetrisBoard[piece2XCordinate, piece2YCordinate] = piece2;
                    tetrisBoard[piece3XCordinate, piece3YCordinate] = piece3;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece2 = null;
                    piece3 = null;
                    piece4 = null;
                }
            }
            // testing for the S piece works // it works!!
            else if (CurrentPieceMade == 2)
            {
                if (Rotate % 4 == 0 && tetrisBoard[piece4XCordinate, piece4YCordinate].y <= BottomWall.y - 60)
                {
                    Rotate++;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += 40;

                    piece3 = tetrisBoard[piece3XCordinate, piece3YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece3XCordinate, piece3YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece3XCordinate -= 1;
                    piece4XCordinate -= 1;
                    piece4YCordinate += 2;

                    tetrisBoard[piece3XCordinate, piece3YCordinate] = piece3;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece3 = null;
                    piece4 = null;
                }
                else if (Rotate % 4 == 1 && tetrisBoard[piece2XCordinate, piece2YCordinate].x <= RightWall.x - 30)
                {
                    Rotate++;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += 20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += 20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -40;

                    piece3 = tetrisBoard[piece3XCordinate, piece3YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece3XCordinate, piece3YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece3XCordinate += 1;
                    piece4XCordinate += 1;
                    piece4YCordinate -= 2;

                    tetrisBoard[piece3XCordinate, piece3YCordinate] = piece3;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece3 = null;
                    piece4 = null;
                }
                else if (Rotate % 4 == 2 && tetrisBoard[piece4XCordinate, piece4YCordinate].y <= BottomWall.y - 60)
                {
                    Rotate++;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += 40;

                    piece3 = tetrisBoard[piece3XCordinate, piece3YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece3XCordinate, piece3YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece3XCordinate -= 1;
                    piece4XCordinate -= 1;
                    piece4YCordinate += 2;

                    tetrisBoard[piece3XCordinate, piece3YCordinate] = piece3;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece3 = null;
                    piece4 = null;
                }
                else if (Rotate % 4 == 3 && tetrisBoard[piece2XCordinate, piece2YCordinate].x <= RightWall.x - 30)
                {
                    Rotate++;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += 20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += 20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -40;

                    piece3 = tetrisBoard[piece3XCordinate, piece3YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece3XCordinate, piece3YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece3XCordinate += 1;
                    piece4XCordinate += 1;
                    piece4YCordinate -= 2;

                    tetrisBoard[piece3XCordinate, piece3YCordinate] = piece3;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece3 = null;
                    piece4 = null;
                }
            }
            //testing for the Z piece // It works!! 
            else if (CurrentPieceMade == 3)
            {
                if (Rotate % 4 == 0 
                    && tetrisBoard[piece1XCordinate, piece1YCordinate].y <= BottomWall.y - 40 
                    && tetrisBoard[piece4XCordinate, piece4YCordinate].y <= BottomWall.y - 40)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += 20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += 20;

                    piece1 = tetrisBoard[piece1XCordinate, piece1YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece1YCordinate += 1;
                    piece4XCordinate -= 2;
                    piece4YCordinate += 1;

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = piece1;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece1 = null;
                    piece4 = null;
                }
                else if (Rotate % 4 == 1 && tetrisBoard[piece2XCordinate, piece2YCordinate].x <= RightWall.x - 30)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += 40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -20;

                    piece1 = tetrisBoard[piece1XCordinate, piece1YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece1YCordinate -= 1;
                    piece4XCordinate += 2;
                    piece4YCordinate -= 1;

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = piece1;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece1 = null;
                    piece4 = null;
                }
                else if (Rotate % 4 == 2 
                    && tetrisBoard[piece1XCordinate, piece1YCordinate].y <= BottomWall.y - 40 
                    && tetrisBoard[piece4XCordinate, piece4YCordinate].y <= BottomWall.y - 40)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += 20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += 20;

                    piece1 = tetrisBoard[piece1XCordinate, piece1YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece1YCordinate += 1;
                    piece4XCordinate -= 2;
                    piece4YCordinate += 1;

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = piece1;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece1 = null;
                    piece4 = null;
                }
                else if (Rotate % 4 == 3 && tetrisBoard[piece2XCordinate, piece2YCordinate].x <= RightWall.x - 30)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += 40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -20;

                    piece1 = tetrisBoard[piece1XCordinate, piece1YCordinate];
                    piece4 = tetrisBoard[piece4XCordinate, piece4YCordinate];

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = null;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = null;

                    piece1YCordinate -= 1;
                    piece4XCordinate += 2;
                    piece4YCordinate -= 1;

                    tetrisBoard[piece1XCordinate, piece1YCordinate] = piece1;
                    tetrisBoard[piece4XCordinate, piece4YCordinate] = piece4;

                    piece1 = null;
                    piece4 = null;
                }
            }
            //testing for the L piece // works!! 
            else if (CurrentPieceMade == 4)
            {
                if (Rotate % 4 == 0 && tetrisBoard[piece4XCordinate, piece4YCordinate].x <= RightWall.x - 30)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].x += +40;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += +20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].y += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += -40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -20;
                }
                else if (Rotate % 4 == 1 && tetrisBoard[piece1XCordinate, piece1YCordinate].y <= BottomWall.y - 60 
                    && tetrisBoard[piece2XCordinate, piece2YCordinate].y <= BottomWall.y - 40)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].x += -20;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += +40;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].y += 20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += +20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -20;
                }
                else if (Rotate % 4 == 2 && tetrisBoard[piece3XCordinate, piece3YCordinate].x <= RightWall.x - 40)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].x += -20;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += +20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += +20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += +40;
                }
                else if (Rotate % 4 == 3 && tetrisBoard[piece3XCordinate, piece3YCordinate].y <= BottomWall.y - 40 
                    && tetrisBoard[piece4XCordinate, piece4YCordinate].y <= BottomWall.y - 60)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += -20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += -40;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += 20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += 40;
                }
            }
            //testing for the J piece // IT WORKSSSSS THIS ONE TOOK SO LONG!! 
            else if (CurrentPieceMade == 5)
            {
                if (Rotate % 4 == 0 && tetrisBoard[piece1XCordinate, piece1YCordinate].x <= RightWall.x - 50)
                {
                    Rotate++;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += 20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].y += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += 40;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += -40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += 60;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -20;
                }
                else if (Rotate % 4 == 1 && tetrisBoard[piece1XCordinate, piece1YCordinate].y <= BottomWall.y - 60 
                    && tetrisBoard[piece2XCordinate, piece2YCordinate].y <= BottomWall.y - 40)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += 40;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += -20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].y += 20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += -40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -20;
                }
                else if (Rotate % 4 == 2 
                    && tetrisBoard[piece4XCordinate, piece4YCordinate].x <= RightWall.x - 30 
                    && tetrisBoard[piece3XCordinate, piece3YCordinate].y <= BottomWall.y - 40)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].x += 40;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += -20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += 20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += 20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -20;
                }
                else if (Rotate % 4 == 3 
                    && tetrisBoard[piece2XCordinate, piece2YCordinate].x >= LeftWall.x + 50 
                    && tetrisBoard[piece3XCordinate, piece3YCordinate].y <= BottomWall.y - 40 
                    && tetrisBoard[piece4XCordinate, piece4YCordinate].y <= BottomWall.y - 60)             
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].x += -40;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += -20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += 20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += 40;
                }
                
            }
            //testing for the T // IT WORKS!!
            else if (CurrentPieceMade == 6)
            {
                if (Rotate % 4 == 0 
                    && tetrisBoard[piece2XCordinate, piece2YCordinate].y <= BottomWall.y - 40 
                    && tetrisBoard[piece3XCordinate, piece3YCordinate].y <= BottomWall.y - 60)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].x += 20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].y += 20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += 40;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += -20;
                }
                else if (Rotate % 4 == 1 
                    && tetrisBoard[piece3XCordinate, piece3YCordinate].x <= RightWall.x - 30 
                    && tetrisBoard[piece1XCordinate, piece1YCordinate].y <= BottomWall.y - 40)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].x += 20;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += 20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].x += 20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += -20;
                }
                else if (Rotate % 4 == 2 
                    && tetrisBoard[piece1XCordinate, piece1YCordinate].y <= BottomWall.y - 40 
                    && tetrisBoard[piece4XCordinate, piece4YCordinate].y <= BottomWall.y - 40)
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].x += -40;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += 20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].y += -20;
                    tetrisBoard[piece4XCordinate, piece4YCordinate].y += 20;
                }
                else if (Rotate % 4 == 3 
                    && tetrisBoard[piece4XCordinate, piece4YCordinate].x <= RightWall.x - 30 
                    && tetrisBoard[piece2XCordinate, piece2YCordinate].y <= BottomWall.y - 40 
                    && tetrisBoard[piece3XCordinate, piece3YCordinate].y <= BottomWall.y - 60) 
                {
                    Rotate++;
                    tetrisBoard[piece1XCordinate, piece1YCordinate].y += -40;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].x += 20;
                    tetrisBoard[piece2XCordinate, piece2YCordinate].y += -20;
                    tetrisBoard[piece3XCordinate, piece3YCordinate].x += 40;
                }
            }
        }

        public void UpdateDown()
        {
            moveingDown++;
            if(moveingDown%30 == 0 && tetrisBoard[piece1XCordinate, piece1YCordinate].y + 1 <= BottomWall.y -20 && tetrisBoard[piece2XCordinate, piece2YCordinate].y + 1 <= BottomWall.y -20 && tetrisBoard[piece3XCordinate, piece3YCordinate].y + 1 <= BottomWall.y -20 && tetrisBoard[piece4XCordinate, piece4YCordinate].y + 1 <= BottomWall.y -20)
            {
                tetrisBoard[piece1XCordinate, piece1YCordinate].moveDownward();
                tetrisBoard[piece2XCordinate, piece2YCordinate].moveDownward();
                tetrisBoard[piece3XCordinate, piece3YCordinate].moveDownward();
                tetrisBoard[piece4XCordinate, piece4YCordinate].moveDownward();
            }
        }
        public void Update()
        {

        }
    }
}