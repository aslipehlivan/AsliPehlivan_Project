using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsliPehlivan_Project.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Açık Adres")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "İl")]
        public string City { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Display(Name = "Siparişiniz")]
        public string Product { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Display(Name = "Miktar")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Display(Name = "Miktar Tipi (kg, adet...)")]
        public string QuantityType { get; set; }
    }
}
