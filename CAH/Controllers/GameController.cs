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

// public ActionResult Index()
// {
//     List<WhiteCards> whiteCards = _db.WhiteCards.ToList();
//     List<BlackCards> blackCards = _db.BlackCards.ToList();
//     List<RandomWhiteCards> randomWhiteCard = _db.RandomWhiteCard.ToList();
    
//     CardsViewModel viewModel = new CardsViewModel
//     {
//         WhiteCards = whiteCards,
//         BlackCards = blackCards,
//     };

//     if (randomWhiteCard.Count > 0) // Check if the list is not empty
//     {
//         Random random = new Random();
//         var randomWhiteCards = randomWhiteCard[random.Next(randomWhiteCard.Count)].Text;
//         ViewData["RandomWhiteCard"] = randomWhiteCards;
//     }

//     return View(viewModel);
// }

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

    if (randomWhiteCard.Count > 0) 
    {
        Random random = new Random();
        var randomWhiteCards = randomWhiteCard[random.Next(randomWhiteCard.Count)].Text;
        ViewData["RandomWhiteCard"] = randomWhiteCards;
    }

    return View(viewModel);
}

    public ActionResult Create()
    {
        var existingRandomWhiteCard = TempData["RandomWhiteCard"]?.ToString();
        List<WhiteCards> whiteCard = _db.WhiteCards.ToList();
        Random random = new Random();
        var randomWhiteCard = whiteCard[random.Next(whiteCard.Count)].Text;
        TempData["RandomWhiteCard"] = randomWhiteCard;

        ViewBag.RandomWhiteCard = existingRandomWhiteCard;

        return View(Index());
    }

        public ActionResult Details(int Id)
        {
            return View();
        }
        
    }
}

// public List<WhiteCard> generatedWhiteCard = new List<WhiteCard>();

// public WhiteCard GenerateRandomWhiteCard()
// {
//     Random random = new Random();
//     int totalWhiteCard = GetTotalNumberOfWhiteCard();
//     int randomWhiteIndex = random.Next(0, totalWhiteCard);
//     WhiteCard randomWhiteCard = GetWhiteCardAtIndex(randomWhiteIndex);
//     return randomWhiteCard;
// }

// WhiteCard randomWhiteCard = GenerateRandomWhiteCard();

// if (generatedWhiteCard.Contains(randomWhiteCard))
// {
//     randomWhiteCard = GenerateRandomWhiteCard();
// }

// generatedWhiteCard.Add(randomWhiteCard);