using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CAH.Models;
using CAH.ViewModels;

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
        //     {
        //         List<WhiteCards> model = _db.WhiteCards.ToList(),
        //         List<BlackCards> model2 = _db.BlackCards.ToList();
        //         return View(model);
        //     }

        public ActionResult Index()
        {
            List<WhiteCards> whiteCards = _db.WhiteCards.ToList();
            List<BlackCards> blackCards = _db.BlackCards.ToList();

            CardsViewModel viewModel = new CardsViewModel
            {
                WhiteCards = whiteCards,
                BlackCards = blackCards
            };

            return View(viewModel);
        }

        public ActionResult Details(int Id)
        {
            return View();
        }
        
    }
}


// [HttpGet("/")]
// public ActionResult Index()
// {
//     WhiteCards[] whiteCards = _db.WhiteCards.ToArray();
//     BlackCards[] blackCards = _db.BlackCards.ToArray();
//     Dictionary<string, object[]> model = new Dictionary<string, object[]>();
//     model.Add("whiteCards", whiteCards);
//     model.Add("blackCards", blackCards);
//     return View(model);
// }
