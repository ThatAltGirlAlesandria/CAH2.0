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
        private readonly string initialBlackCard;
        private readonly string initialWhiteCard;
        private readonly Random random = new Random();

        public GameController (CAHContext db)
        {
            _db = db;
            initialBlackCard = _db.BlackCards.FirstOrDefault()?.Text;
            initialWhiteCard = _db.WhiteCards.FirstOrDefault()?.Text;
        }

        public ActionResult Index()
        {
            List<WhiteCards> whiteCards = _db.WhiteCards.ToList();
            List<BlackCards> blackCards = _db.BlackCards.ToList();
            List<RandomWhiteCards> randomWhiteCard = _db.RandomWhiteCard.ToList();
        
            CardsViewModel viewModel = new CardsViewModel
            {
                WhiteCards = whiteCards,
                BlackCards = blackCards,
            };

            ViewBag.InitialBlackCard = initialBlackCard[random.Next(blackCards.Count)];
            ViewBag.InitialWhiteCard = randomWhiteCard[random.Next(randomWhiteCard.Count)].Text;

            return View(viewModel);
        }

        public ActionResult Details(int Id)
        {
            return View();
        }
    }
}
