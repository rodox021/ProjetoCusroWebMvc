using SalesWebMvc.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Data da Venda")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Valor")]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }

       
        public SalesStatus Status { get; set; }

        [Display(Name = "Vendendor")]
        public Seller Seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
