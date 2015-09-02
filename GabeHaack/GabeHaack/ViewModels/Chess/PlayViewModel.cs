using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GabeHaack.ViewModels.Chess
{
    public class PlayViewModel
    {
        public IEnumerable<ChessBoardPartialViewModel> ChessBoardPartialViewModels { get; set; }
    }
}