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

            CardsViewModel viewModel = new CardsViewModel
            {
                WhiteCards = whiteCards,
                BlackCards = blackCards
            };
            
            if (TempData["RandomWhiteCard"] != null)
            {
            ViewData["RandomWhiteCard"] = TempData["RandomWhiteCard"];
            }

            return View(viewModel);
        }

        public ActionResult Create()
        {
            var viewModel = new CardsViewModel
        {
            WhiteCards = _db.WhiteCards.ToList()
        };
    
            Random random = new Random();
            var randomWhiteCard = viewModel.WhiteCards[random.Next(viewModel.WhiteCards.Count)].Text;

            TempData["RandomWhiteCard"] = randomWhiteCard;

            return RedirectToAction("Index");
        }

        // public ActionResult Create()
        //     { var viewModel = new CardsViewModel
        //     {
        //         WhiteCards = _db.WhiteCards.ToList()
        //     };
        //         Random random = new Random();
        //         var randomWhiteCard = viewModel.WhiteCards[random.Next(viewModel.WhiteCards.Count)].Text;

        //         ViewData["RandomWhiteCard"] = randomWhiteCard;

        //     return RedirectToAction("Index", viewModel);
        //     }


        public ActionResult Details(int Id)
        {
            return View();
        }
        
    }
}

public List<WhiteCards> generatedWhiteCards = new List<WhiteCards>();

public WhiteCards GenerateRandomWhiteCard()
{
    Random random = new Random();
    int totalWhiteCards = GetTotalNumberOfWhiteCards();
    int randomWhiteIndex = random.Next(0, totalWhiteCards);
    WhiteCards randomWhiteCard = GetWhiteCardAtIndex(randomWhiteIndex);
    return randomWhiteCard;
}

WhiteCards randomWhiteCard = GenerateRandomWhiteCard();

if (generatedWhiteCards.Contains(randomWhiteCard))
{
    randomWhiteCard = GenerateRandomWhiteCard();
}

generatedWhiteCards.Add(randomWhiteCard);