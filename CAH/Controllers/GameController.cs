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
    List<RandomWhiteCards> randomWhiteCard = _db.RandomWhiteCard.ToList();
    
    CardsViewModel viewModel = new CardsViewModel
    {
        WhiteCards = whiteCards,
        BlackCards = blackCards,
    };

    if (randomWhiteCard.Count > 0) // Check if the list is not empty
    {
        Random random = new Random();
        var randomWhiteCards = randomWhiteCard[random.Next(randomWhiteCard.Count)].Text;
        ViewData["RandomWhiteCard"] = randomWhiteCards;
    }

    return View(viewModel);
}

        // public ActionResult Index()
        // {
        //     List<WhiteCards> whiteCards = _db.WhiteCards.ToList();
        //     List<BlackCards> blackCards = _db.BlackCards.ToList();
        //     List<RandomWhiteCards> randomWhiteCard = _db.RandomWhiteCard.ToList();
        //     Random random = new Random();
        //     var randomWhiteCards = randomWhiteCard[random.Next(whiteCards.Count)].Text;

        //     CardsViewModel viewModel = new CardsViewModel
        //     {
        //         WhiteCards = whiteCards,
        //         BlackCards = blackCards,
        //     };
            
        //     if (TempData["RandomWhiteCard"] != null)
        //     {
        //     ViewData["RandomWhiteCard"] = TempData["RandomWhiteCard"];
        //     }

        //     return View(viewModel);
        // }

    // public ActionResult Create()
    // {
    //     List<WhiteCards> whiteCard = _db.WhiteCards.ToList();
    //     Random random = new Random();
    //     var randomWhiteCard = whiteCard[random.Next(whiteCard.Count)].Text;

    //     ViewBag.RandomWhiteCard = randomWhiteCard; 

    //     return RedirectToAction("Index"); 
    // }

    public ActionResult Create()
    {
        List<WhiteCards> whiteCard = _db.WhiteCards.ToList();
        Random random = new Random();
        var randomWhiteCard = whiteCard[random.Next(whiteCard.Count)].Text;

        ViewBag.RandomWhiteCard = randomWhiteCard;

        return PartialView("_RandomWhiteCardPartial");
    }


        // public ActionResult Create()
        //     { var viewModel = new CardsViewModel
        //     {
        //         WhiteCard = _db.WhiteCard.ToList()
        //     };
        //         Random random = new Random();
        //         var randomWhiteCard = viewModel.WhiteCard[random.Next(viewModel.WhiteCard.Count)].Text;

        //         ViewData["RandomWhiteCard"] = randomWhiteCard;

        //     return RedirectToAction("Index", viewModel);
        //     }


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