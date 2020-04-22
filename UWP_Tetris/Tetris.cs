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
        public bool gameOver { get; private set; }

        private bool isUserPieceMovingLeftward;
        
        public Tetris()
        {
            gameOver = false;

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
            int CreatePiece = 6;  //me testing the blocks ignore will delete after done with checking
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
            // T piece
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
                if (piece1.x - 20 >= LeftWall.x + 10 && piece2.x - 20 >= LeftWall.x + 10 && piece3.x - 20 >= LeftWall.x + 10 && piece4.x - 20 >= LeftWall.x + 10)
                {
                    piece1.x += changeIntX;
                    piece2.x += changeIntX;
                    piece3.x += changeIntX;
                    piece4.x += changeIntX;
                }
            }

            else
            {
                if (piece1.x + 20 <= RightWall.x - 10 && piece2.x + 20 <= RightWall.x - 10 && piece3.x + 20 <= RightWall.x - 10 && piece4.x + 20 <= RightWall.x - 10)
                {
                    piece1.x += changeIntX;
                    piece2.x += changeIntX;
                    piece3.x += changeIntX;
                    piece4.x += changeIntX;
                }
            }
        }

        public void RotateTetrisPiece()
        {    // the boundries for the L shapes works testing completed 
            if (CurrentPieceMade == 1)
            {
                if (Rotate % 4 == 0 && piece1.x <= RightWall.x - 70)
                {
                    Rotate++;
                    piece2.x += 20;
                    piece2.y += -20;
                    piece3.x += 40;
                    piece3.y += -40;
                    piece4.x += 60;
                    piece4.y += -60;
                }
                else if (Rotate % 4 == 1)
                {
                    Rotate++;
                    piece2.x += -20;
                    piece2.y += 20;
                    piece3.x += -40;
                    piece3.y += 40;
                    piece4.x += -60;
                    piece4.y += 60;
                }
                else if (Rotate % 4 == 2 && piece1.x <= RightWall.x - 70)
                {
                    Rotate++;
                    piece2.x += 20;
                    piece2.y += -20;
                    piece3.x += 40;
                    piece3.y += -40;
                    piece4.x += 60;
                    piece4.y += -60;
                }
                else if (Rotate % 4 == 3)
                {
                    Rotate++;
                    piece2.x += -20;
                    piece2.y += 20;
                    piece3.x += -40;
                    piece3.y += 40;
                    piece4.x += -60;
                    piece4.y += 60;
                }
            }
            // testing for the S piece works // it works!!
            else if (CurrentPieceMade == 2)
            {
                if (Rotate % 4 == 0)
                {
                    Rotate++;
                    piece3.x += -20;
                    piece4.x += -20;
                    piece4.y += 40;
                }
                else if (Rotate % 4 == 1 && piece2.x <= RightWall.x - 30)
                {
                    Rotate++;
                    piece3.x += 20;
                    piece4.x += 20;
                    piece4.y += -40;
                }
                else if (Rotate % 4 == 2 )
                {
                    Rotate++;
                    piece3.x += -20;
                    piece4.x += -20;
                    piece4.y += 40;
                }
                else if (Rotate % 4 == 3 && piece2.x <= RightWall.x - 30)
                {
                    Rotate++;
                    piece3.x += 20;
                    piece4.x += 20;
                    piece4.y += -40;
                }
            }
            //testing for the Z piece // It works!! 
            else if (CurrentPieceMade == 3)
            {
                if (Rotate % 4 == 0)
                {
                    Rotate++;
                    piece1.y += 20;
                    piece4.x += -40;
                    piece4.y += 20;
                }
                else if (Rotate % 4 == 1 && piece2.x <= RightWall.x - 30)
                {
                    Rotate++;
                    piece1.y += -20;
                    piece4.x += 40;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 2)
                {
                    Rotate++;
                    piece1.y += 20;
                    piece4.x += -40;
                    piece4.y += 20;
                }
                else if (Rotate % 4 == 3 && piece2.x <= RightWall.x - 30)
                {
                    Rotate++;
                    piece1.y += -20;
                    piece4.x += 40;
                    piece4.y += -20;
                }
            }
            //testing for the L piece // works!! 
            else if (CurrentPieceMade == 4)
            {
                if (Rotate % 4 == 0 && piece4.x <= RightWall.x - 30)
                {
                    Rotate++;
                    piece1.x += +40;
                    piece2.x += +20;
                    piece2.y += -20;
                    piece3.y += -40;
                    piece4.x += -20;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 1)
                {
                    Rotate++;
                    piece1.x += -20;
                    piece1.y += +40;
                    piece2.y += 20;
                    piece3.x += +20;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 2 && piece3.x <= RightWall.x - 30)
                {
                    Rotate++;
                    piece1.x += -20;
                    piece1.y += -20;
                    piece3.x += +20;
                    piece3.y += +20;
                    piece4.x += +40;
                }
                else if (Rotate % 4 == 3)
                {
                    Rotate++;
                    piece1.y += -20;
                    piece2.x += -20;
                    piece3.x += -40;
                    piece3.y += 20;
                    piece4.x += -20;
                    piece4.y += 40;
                }
            }
            //testing for the J piece // IT WORKSSSSS THIS ONE TOOK SO LONG!! 
            else if (CurrentPieceMade == 5)
            {
                if (Rotate % 4 == 0 && piece1.x <= RightWall.x - 50)
                {
                    Rotate++;
                    piece2.x += 20;
                    piece2.y += -20;
                    piece3.x += 40;
                    piece3.y += -40;
                    piece4.x += 60;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 1)
                {
                    Rotate++;
                    piece1.y += 40;
                    piece2.x += -20;
                    piece2.y += 20;
                    piece3.x += -40;
                    piece4.x += -20;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 2 && piece4.x <= RightWall.x - 30)
                {
                    Rotate++;
                    piece1.x += 40;
                    piece1.y += -20;
                    piece2.x += 20;
                    piece3.y += 20;
                    piece4.x += -20;
                }
                else if (Rotate % 4 == 3 && piece2.x >= LeftWall.x + 50)             
                {
                    Rotate++;
                    piece1.x += -40;
                    piece1.y += -20;
                    piece2.x += -20;
                    piece3.y += 20;
                    piece4.x += -20;
                    piece4.y += 40;
                }
                
            }
            //testing for the
            else if (CurrentPieceMade == 6)
            {
                if (Rotate % 4 == 0)
                {
                    Rotate++;
                    piece1.x += 20;
                    piece2.y += 20;
                    piece3.x += -20;
                    piece3.y += 40;
                    piece4.x += -20;
                }
                else if (Rotate % 4 == 1)
                {
                    Rotate++;
                    piece1.x += 20;
                    piece1.y += 20;
                    piece3.x += -20;
                    piece3.y += -20;
                    piece4.x += 20;
                    piece4.y += -20;
                }
                else if (Rotate % 4 == 2)
                {
                    Rotate++;
                    piece1.x += -40;
                    piece1.y += 20;
                    piece2.x += -20;
                    piece3.y += -20;
                    piece4.y += 20;
                }
                else if (Rotate % 4 == 3)
                {
                    Rotate++;
                    piece1.y += -40;
                    piece2.x += 20;
                    piece2.y += -20;
                    piece3.x += 40;
                }
            }
        }
    }
}