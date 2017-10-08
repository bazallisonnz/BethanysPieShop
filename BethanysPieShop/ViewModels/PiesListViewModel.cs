namespace BethanysPieShop.ViewModels
{
    using System.Collections.Generic;
    using BethanysPieShop.Models;

    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
