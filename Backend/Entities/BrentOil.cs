using System.ComponentModel.DataAnnotations;
using System;

namespace Backend.Entities
{
    public class BrentOil
    {
        [Key]
        public DateTime Date { get; set; }

        public float price { get; set; }
    }
}
