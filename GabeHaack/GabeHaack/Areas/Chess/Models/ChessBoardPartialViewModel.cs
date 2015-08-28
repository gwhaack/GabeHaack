using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chess.Models;

namespace GabeHaack.Areas.Chess.Models
{
    public class ChessBoardPartialViewModel
    {
        public ChessBoard ChessBoard { get; set; }

        public ChessBoardPartialViewModel(ChessBoard chessBoard)
        {
            ChessBoard = chessBoard;
        }
    }
}