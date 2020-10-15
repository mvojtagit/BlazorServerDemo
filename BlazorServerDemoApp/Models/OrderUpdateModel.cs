using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemoApp.Models
{
    public class OrderUpdateModel
    {
        public int Id { get; set; }

        [DisplayName("Name for narudzba")]
        [MaxLength(20, ErrorMessage = "Max broj znakova je 20")]
        [MinLength(3, ErrorMessage = "Unesi barem tri znaka")]
        [Required]
        public string OrderName { get; set; }

    }
}
