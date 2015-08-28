using Chess.Models;
using GabeHaack.Areas.Chess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GabeHaack.Areas.Chess.Controllers
{
    public class ChessController : Controller
    {
        // GET: Chess/Chess
        public ActionResult Index()
        {
            var chessBoard = new ChessBoard();
            return View(new ChessBoardPartialViewModel(chessBoard));
        }
    }
}