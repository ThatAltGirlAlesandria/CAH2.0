using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CAH.Models;

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
            List<WhiteCards> model = _db.WhiteCards.ToList();
            return View(model);
        }
        public ActionResult Details(int Id)
        {
            return View();
        }
    }
}
