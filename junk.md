    public ActionResult Index()
    {
        List<WhiteCards> whiteCards = _db.WhiteCards.ToList();
        List<BlackCards> blackCards = _db.BlackCards.ToList();
        // List<RandomWhiteCards> randomWhiteCard = _db.RandomWhiteCard.ToList();
        //lmw comment out above^
        
        CardsViewModel viewModel = new CardsViewModel
        {
            WhiteCards = whiteCards,
            BlackCards = blackCards,
        };
        ViewBag.InitialBlackCard = initialBlackCard; //lmw add
        ViewBag.InitialWhiteCard = initialWhiteCard; //lmw add

        // if (randomWhiteCard.Count > 0) 
        // {
        //     Random random = new Random();
        //     var randomWhiteCards = randomWhiteCard[random.Next(randomWhiteCard.Count)].Text;
        
            // ViewData["RandomWhiteCard"] = initialWhiteCard;
            // lmw comment out above^

        return View(viewModel);
    }


        [HttpPost]
    public ActionResult Create()
    {

        var existingRandomWhiteCard = TempData["RandomWhiteCard"]?.ToString();
        List<WhiteCards> whiteCard = _db.WhiteCards.ToList();
        Random random = new Random();
        var randomWhiteCard = whiteCard[random.Next(whiteCard.Count)].Text;
        TempData["RandomWhiteCard"] = randomWhiteCard;

        ViewBag.RandomWhiteCard = existingRandomWhiteCard;

        return RedirectToAction("Index");
    }





  
  @if (TempData["RandomWhiteCard"] != null)
  {
      <div class="whiteCard">
        <p class="random-card">@TempData["RandomWhiteCard"]</p> 
      </div>  
  }


  @using (Html.BeginForm("Create", "Game", FormMethod.Post))
{
  <button type="submit">Generate second card</button>
}




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
        private readonly string initialBlackCard; //lmw add
        private readonly string initialWhiteCard; //lmw add
        private readonly Random random = new Random(); //lmw add
        private readonly string randomWhiteCards = initialWhiteCard[random.Next(randomWhiteCard.Count)].Text;
        public GameController (CAHContext db)
        {
            _db = db;
            initialBlackCard = _db.BlackCards.FirstOrDefault()?.Text;
            initialWhiteCard = _db.WhiteCards.[random.Next(randomWhiteCard.Count)].Text;
        }

    public ActionResult Index()
    {
        List<WhiteCards> whiteCards = _db.WhiteCards.ToList();
        List<BlackCards> blackCards = _db.BlackCards.ToList();
        // List<RandomWhiteCards> randomWhiteCard = _db.RandomWhiteCard.ToList();
        //lmw comment out above^
        
        CardsViewModel viewModel = new CardsViewModel
        {
            WhiteCards = whiteCards,
            BlackCards = blackCards,
        };
        ViewBag.InitialBlackCard = initialBlackCard; //lmw add
        ViewBag.InitialWhiteCard = initialWhiteCard; //lmw add

            // Random random = new Random();
            // var randomWhiteCards = initialWhiteCard[random.Next(randomWhiteCard.Count)].Text;
        
            // ViewData["RandomWhiteCard"] = initialWhiteCard;
            // lmw comment out above^

        return View(viewModel);
    }

        public ActionResult Details(int Id)
        {
            return View();
        }
    }
}



not as good below

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
        private readonly string initialBlackCard; //lmw add
        private readonly string initialWhiteCard; //lmw add
        private readonly Random random = new Random(); //lmw add

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
        // var randomWhiteCard1 = initialWhiteCard[random.Next(randomWhiteCard.Count)];
        
        
        CardsViewModel viewModel = new CardsViewModel
        {
            WhiteCards = whiteCards,
            BlackCards = blackCards,
        };

        ViewBag.InitialBlackCard = initialBlackCard[random.Next(blackCards.Count)]; //lmw add
        ViewBag.InitialWhiteCard = randomWhiteCard[random.Next(randomWhiteCard.Count)].Text; //lmw add

            // Random random = new Random();
            // var randomWhiteCards = initialWhiteCard[random.Next(randomWhiteCard.Count)].Text;
        
            // ViewData["RandomWhiteCard"] = initialWhiteCard;
            // lmw comment out above^

        return View(viewModel);
    }

        public ActionResult Details(int Id)
        {
            return View();
        }
    }
}
