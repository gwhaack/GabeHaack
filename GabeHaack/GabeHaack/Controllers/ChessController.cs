using Chess.Models;
using GabeHaack.ViewModels.Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GabeHaack.Controllers
{
    public class ChessController : Controller
    {
        // GET: Chess/Chess
        public ActionResult Index()
        {
            return RedirectToAction("Play");
        }

        public ActionResult Play()
        {
            var chessBoard = new ChessBoard();
            var viewModel = new ChessBoardPartialViewModel
            {
                Id = 1,
                ChessBoard = chessBoard,
            };
            return View(viewModel);
        }
    }
}