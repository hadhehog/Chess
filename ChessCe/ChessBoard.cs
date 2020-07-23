using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCe
{
    public class ChessBoard
    {
        private string[,] chessBoard;
        public const int DIMENSION = 8;                                                   //original 8x8 board

        private Move move;

        public ChessBoard()
        {
            move = new Move();
            chessBoard = new string[DIMENSION, DIMENSION];
            ChessBoardHorizontalSymbol = "+---";
            ChessBoardVerticalSymbol = "| ";
        }

        public string ChessBoardHorizontalSymbol { get; set; }
        public string ChessBoardVerticalSymbol { get; set; }

        public void displayChessBoard()
        {
            while (!move.Exit)
            {
                Console.Clear();
                Console.WriteLine("    0   1   2   3   4   5   6   7");                   // x axis header

                for (int r = 0; r < DIMENSION; r++)
                {
                    Console.Write("  ");                                                  //left spacing - 2 spaces
                    for (int c = 0; c < DIMENSION; c++)
                    {
                        Console.Write(ChessBoardHorizontalSymbol);                        //write the horizontal pattern
                    }

                    Console.Write("+\n");

                    for (int c = 0; c < DIMENSION; c++)
                    {
                        if (c == 0)
                            Console.Write(r + " ");                                       //y axis header

                        Console.Write(ChessBoardVerticalSymbol + Pawn.pawns[r, c] + " "); //display the pawn centered
                    }

                    Console.Write("|\n");
                }

                                                                                          //the bottom line 
                Console.Write("  ");                                                      //left spacing
                for (int c = 0; c < DIMENSION; c++)
                {
                    Console.Write(ChessBoardHorizontalSymbol);
                }

                Console.Write("+\n\n");
                move.MakeMove();
            }
        }

    }
}
