using Chess.Models;
using GabeHaack.Controllers;
using GabeHaack.ViewModels.Chess;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web.Mvc;
using Xunit;

namespace GabeHaack.Tests.Controllers
{
    [ExcludeFromCodeCoverage]
    public class ChessControllerTest
    {
        [Fact]
        public void Index()
        {
            var chessController = new ChessController();
            var result = chessController.Index() as RedirectToRouteResult;
            Assert.NotEmpty(result.RouteValues);
            var route = result.RouteValues.FirstOrDefault();
            Assert.Equal("action", route.Key);
            Assert.Equal("Play", route.Value);

        }

        [Fact]
        public void Play()
        {
            var chessController = new ChessController();
            var result = chessController.Play() as ViewResult;
            Assert.NotNull(result.Model);
            Assert.IsType<ChessBoardPartialViewModel>(result.Model);
            var viewModel = (ChessBoardPartialViewModel) result.Model;
            Assert.Equal(1, viewModel.Id);
            Assert.NotNull(viewModel.ChessBoard);
        }
    }
}
