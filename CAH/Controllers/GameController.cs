using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CAH.Models;
using CAH.ViewModels;
using System;

namespace CAH.Controllers
{
    public class GameController : Controller
    {
        private readonly CAHContext _db;
        public GameController (CAHContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<WhiteCards> whiteCards = _db.WhiteCards.ToList();
            List<BlackCards> blackCards = _db.BlackCards.ToList();

            Random random = new Random();
            var randomWhiteCard1 = whiteCards[random.Next(whiteCards.Count)].Text;
            var randomWhiteCard2 = whiteCards[random.Next(whiteCards.Count)].Text;
            var randomBlackCard = blackCards[random.Next(blackCards.Count)].Text;

            CardsViewModel viewModel = new CardsViewModel
            {
                WhiteCard1 = randomWhiteCard1,
                WhiteCard2 = randomWhiteCard2,
                BlackCard = randomBlackCard,
            };

            // ViewBag.BlackCard = randomBlackCard;
            // ViewBag.WhiteCard1 = randomWhiteCard1;

            return View(viewModel);
        }

        public ActionResult Details(int Id)
        {
            return View();
        }
    }
}
