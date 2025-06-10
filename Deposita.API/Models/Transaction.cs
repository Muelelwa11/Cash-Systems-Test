using System;
using System.ComponentModel.DataAnnotations;

namespace Deposita.API.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}