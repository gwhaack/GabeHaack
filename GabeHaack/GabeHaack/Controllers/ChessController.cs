using Chess.Models;
using GabeHaack.ViewModels.Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace GabeHaack.Controllers
{
    public class ChessController : Controller
    {
        private Board _chessBoard { get; set; }

        public ChessController()
        {
            _chessBoard = new Board();
        }

        public ActionResult Index()
        {
            return RedirectToAction("Play");
        }

        public ActionResult Play()
        {
            return View(_chessBoard);
        }

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult Model()
        {
            return Json(_chessBoard, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Move()
        {
            throw new NotImplementedException();
        }
    }
}