using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using CAH.Models;

namespace CAH.ViewModels
{

    public class CardsViewModel
    {
        public List<WhiteCards> WhiteCards { get; set; }
        public List<BlackCards> BlackCards { get; set; }
        public List<RandomWhiteCards> RandomWhiteCard { get; set; }
    }
}