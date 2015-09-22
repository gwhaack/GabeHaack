using Chess;
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
        private Game _game { get; set; }

        public ChessController()
        {
            _game = new Game();
            _game.Start();
        }

        public ActionResult Index()
        {
            return RedirectToAction("Play");
        }

        public ActionResult Play()
        {
            return View(_game);
        }

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult State()
        {
            var state = _game.State;
            return Json(state, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Move()
        {
            throw new NotImplementedException();
        }
    }
}