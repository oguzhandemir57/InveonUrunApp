using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime? CreateDate{ get; set; }
        public string CreateUser{ get; set; }
        public int Status{ get; set; }
        [NotMapped]
        public ProductDetail ProductDetail { get; set; }
    }
}