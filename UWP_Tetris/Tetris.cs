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
        private Random rnd = new Random();
        private int Rotate = 4;
        private int CurrentPieceMade;

        public Tetris()
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
        }

        public void setPiece()
        {
            int CreatePiece = rnd.Next(7);
            Rotate = 4;
            CurrentPieceMade = CreatePiece;
            //O piece
            if (CreatePiece == 0)
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
                    x = 120,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Yellow
                };

                piece4 = new TetrisPiece
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
            }
            //S Piece
            else if (CreatePiece == 2)
            {
                piece3 = new TetrisPiece
                {
                    x = 100,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Red
                };

                piece4 = new TetrisPiece
                {
                    x = 120,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Red
                };

                piece2 = new TetrisPiece
                {
                    x = 100,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Red
                };

                piece1 = new TetrisPiece
                {
                    x = 80,
                    y = 70,
                    width = 20,
                    height = 20,
                    color = Colors.Red
                };
            }
            //Z Piece
            else if (CreatePiece == 3)
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
            }
            //L Piece
            else if (CreatePiece == 4)
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
            }
            //J Piece
            else if (CreatePiece == 5)
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
            }
            else if (CreatePiece == 6)
            {
                piece2 = new TetrisPiece
                {
                    x = 100,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Purple
                };

                piece3 = new TetrisPiece
                {
                    x = 120,
                    y = 50,
                    width = 20,
                    height = 20,
                    color = Colors.Purple
                };

                piece1 = new TetrisPiece
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

        public void RotateTetrisPiece()
        {
            if (CurrentPieceMade == 1)
            {
                Rotate++;
                if (Rotate % 4 == 1)
                {
                    piece1.x += 0;
                    piece1.y += 0;
                    piece2.x += 20;
                    piece2.y += -20;
                    piece3.x += 40;
                    piece3.y += -40;
                    piece4.x += 60;
                    piece4.y += -60;
                }
                else if (Rotate % 4 == 2)
                {
                    piece1.x += 0;
                    piece1.y += 0;
                    piece2.x += -20;
                    piece2.y += 20;
                    piece3.x += -40;
                    piece3.y += 40;
                    piece4.x += -60;
                    piece4.y += 60;
                }
                else if (Rotate % 4 == 3)
                {
                    piece1.x += 0;
                    piece1.y += 0;
                    piece2.x += 20;
                    piece2.y += -20;
                    piece3.x += 40;
                    piece3.y += -40;
                    piece4.x += 60;
                    piece4.y += -60;
                }
                else if (Rotate % 4 == 0)
                {
                    piece1.x += 0;
                    piece1.y += 0;
                    piece2.x += -20;
                    piece2.y += 20;
                    piece3.x += -40;
                    piece3.y += 40;
                    piece4.x += -60;
                    piece4.y += 60;
                }
            }
            else if (CurrentPieceMade == 2)
            {
                Rotate++;
                if (Rotate % 4 == 1)
                {
                    piece1.x += 0;
                    piece1.y += 0;
                    piece2.x += 0;
                    piece2.y += 0;
                    piece3.x += -20;
                    piece3.y += 0;
                    piece4.x += -20;
                    piece4.y += 40;
                }
                else if (Rotate % 4 == 2)
                {
                    piece1.x += 0;
                    piece1.y += 0;
                    piece2.x += 0;
                    piece2.y += 0;
                    piece3.x += 20;
                    piece3.y += 0;
                    piece4.x += 20;
                    piece4.y += -40;
                }
                else if (Rotate % 4 == 3)
                {
                    piece1.x += 0;
                    piece1.y += 0;
                    piece2.x += 0;
                    piece2.y += 0;
                    piece3.x += -20;
                    piece3.y += 0;
                    piece4.x += -20;
                    piece4.y += 40;
                }
                else if (Rotate % 4 == 0)
                {
                    piece1.x += 0;
                    piece1.y += 0;
                    piece2.x += 0;
                    piece2.y += 0;
                    piece3.x += 20;
                    piece3.y += 0;
                    piece4.x += 20;
                    piece4.y += -40;
                }
            }
            else if (CurrentPieceMade == 3)
            {
                Rotate++;
                if (Rotate % 4 == 1)
                {
                    piece1.x += 0;
                    piece1.y += 20;
                    piece2.x += 0;
                    piece2.y += 0;
                    piece3.x += 0;
                    piece3.y += 0;
                    piece4.x += -40;
                    piece4.y += 20;
                }
                else if (Rotate % 4 == 2)
                {
                    piece1.x += 0;
                    piece1.y += -20;
                    piece2.x += 0;
                    piece2.y += 0;
                    piece3.x += 0;
                    piece3.y += 0;
                    piece4.x += 40;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 3)
                {
                    piece1.x += 0;
                    piece1.y += 20;
                    piece2.x += 0;
                    piece2.y += 0;
                    piece3.x += 0;
                    piece3.y += 0;
                    piece4.x += -40;
                    piece4.y += 20;
                }
                else if (Rotate % 4 == 0)
                {
                    piece1.x += 0;
                    piece1.y += -20;
                    piece2.x += 0;
                    piece2.y += 0;
                    piece3.x += 0;
                    piece3.y += 0;
                    piece4.x += 40;
                    piece4.y += -20;
                }
            }
            else if (CurrentPieceMade == 4)
            {
                Rotate++;
                if (Rotate % 4 == 1)
                {
                    piece1.x += +40;
                    piece1.y += 0;
                    piece2.x += +20;
                    piece2.y += -20;
                    piece3.x += 0;
                    piece3.y += -40;
                    piece4.x += -20;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 2)
                {
                    piece1.x += -20;
                    piece1.y += +40;
                    piece2.x += 0;
                    piece2.y += 20;
                    piece3.x += +20;
                    piece3.y += 0;
                    piece4.x += 0;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 3)
                {
                    piece1.x += -20;
                    piece1.y += -20;
                    piece2.x += 0;
                    piece2.y += 0;
                    piece3.x += +20;
                    piece3.y += +20;
                    piece4.x += +40;
                    piece4.y += 0;
                }
                else if (Rotate % 4 == 0)
                {
                    piece1.x += 0;
                    piece1.y += -20;
                    piece2.x += -20;
                    piece2.y += 0;
                    piece3.x += -40;
                    piece3.y += 20;
                    piece4.x += -20;
                    piece4.y += 40;
                }
            }
            else if (CurrentPieceMade == 5)
            {
                Rotate++;
                if (Rotate % 4 == 1)
                {
                    piece1.x += 0;
                    piece1.y += 0;
                    piece2.x += 20;
                    piece2.y += -20;
                    piece3.x += 40;
                    piece3.y += -40;
                    piece4.x += 60;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 2)
                {
                    piece1.x += 0;
                    piece1.y += 40;
                    piece2.x += -20;
                    piece2.y += 20;
                    piece3.x += -40;
                    piece3.y += 0;
                    piece4.x += -20;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 3)
                {
                    piece1.x += 40;
                    piece1.y += -20;
                    piece2.x += 20;
                    piece2.y += 0;
                    piece3.x += 0;
                    piece3.y += 20;
                    piece4.x += -20;
                    piece4.y += 0;
                }
                else if (Rotate % 4 == 0)
                {
                    piece1.x += -40;
                    piece1.y += -20;
                    piece2.x += -20;
                    piece2.y += 0;
                    piece3.x += 0;
                    piece3.y += 20;
                    piece4.x += -20;
                    piece4.y += 40;
                }
                
            }
            else if (CurrentPieceMade == 6)
            {
                Rotate++;
                if (Rotate % 4 == 1)
                {
                    piece1.x += 20;
                    piece1.y += 0;
                    piece2.x += 0;
                    piece2.y += 20;
                    piece3.x += -20;
                    piece3.y += 40;
                    piece4.x += -20;
                    piece4.y += 0;
                }
                else if (Rotate % 4 == 2)
                {
                    piece1.x += 20;
                    piece1.y += 20;
                    piece2.x += 0;
                    piece2.y += 0;
                    piece3.x += -20;
                    piece3.y += -20;
                    piece4.x += 20;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 3)
                {
                    piece1.x += -40;
                    piece1.y += 20;
                    piece2.x += -20;
                    piece2.y += 0;
                    piece3.x += 0;
                    piece3.y += -20;
                    piece4.x += 0;
                    piece4.y += 20;
                }
                else if (Rotate % 4 == 0)
                {
                    piece1.x += 0;
                    piece1.y += -40;
                    piece2.x += 20;
                    piece2.y += -20;
                    piece3.x += 40;
                    piece3.y += 0;
                    piece4.x += 0;
                    piece4.y += 0;
                }
            }
        }
    }
}