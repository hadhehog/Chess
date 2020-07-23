using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCe
{
    public class Pawn
    {
     #region WhatIsPawn
        public const char PAWN_SYMBOL = 'X';
        public const char SPACE = ' ';
        public static char[,] pawns;
     #endregion
      
        public Pawn()
        {
            pawns = new char[ChessBoard.DIMENSION, ChessBoard.DIMENSION];
            initPawn();           //populate pawn array with X and Spaces
        }
    }
}
