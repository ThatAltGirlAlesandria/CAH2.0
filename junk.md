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