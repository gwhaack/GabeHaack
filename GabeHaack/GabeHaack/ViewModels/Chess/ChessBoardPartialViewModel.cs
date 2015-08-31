using Chess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GabeHaack.ViewModels.Chess
{
    public class ChessBoardPartialViewModel
    {
        public int Id { get; set; }
        public ChessBoard ChessBoard { get; set; }
    }
}