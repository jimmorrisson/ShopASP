using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Enter the name"), StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter the surname"), StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Enter the street"), StringLength(50)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Enter the city"), StringLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter the zip code"), StringLength(6)]
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime AddedDateTime { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal ValueOfOrder { get; set; }

        List<PositionsOrder> PositionsOrder { get; set; }
    }
}