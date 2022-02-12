using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Entities
{
    public class ProductDetail
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Description{ get; set; }
        public string Barcode{ get; set; }
        public decimal Price{ get; set; }
        public string Image{ get; set; }
        public int Quantity{ get; set; }
        [NotMapped]
        public string ProductName { get; set; }
    }
}