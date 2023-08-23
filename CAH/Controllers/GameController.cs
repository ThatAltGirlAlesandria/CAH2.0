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
        
            CardsViewModel viewModel = new CardsViewModel
            {
                WhiteCards = whiteCards,
                BlackCards = blackCards,
            };
            
            var randomWhiteCard1 = whiteCards[random.Next(whiteCards.Count)].Text;
            var randomWhiteCard2 = whiteCards[random.Next(whiteCards.Count)].Text;
            var randomWhiteCard3 = whiteCards[random.Next(whiteCards.Count)].Text;
            var randomWhiteCard4 = whiteCards[random.Next(whiteCards.Count)].Text;
            var randomWhiteCard5 = whiteCards[random.Next(whiteCards.Count)].Text;

            var randomBlackCard = blackCards[random.Next(blackCards.Count)].Text;

            ViewBag.InitialBlackCard = randomBlackCard;
            
            ViewBag.whiteCard1 = randomWhiteCard1;
            ViewBag.whiteCard2 = randomWhiteCard2;
            ViewBag.whiteCard3 = randomWhiteCard3;
            ViewBag.whiteCard4 = randomWhiteCard4;
            ViewBag.whiteCard5 = randomWhiteCard5;

            return View(viewModel);
        }

        public ActionResult Details(int Id)
        {
            return View();
        }
    }
}
