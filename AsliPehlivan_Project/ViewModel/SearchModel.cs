using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsliPehlivan_Project.ViewModel
{
    public class SearchModel
    {
        [Display(Name = "Aramak istediğiniz şehri yazınız.")]
        public string SearchText { get; set; }
        public List<Models.Order> Results { get; set; }
    }
}
