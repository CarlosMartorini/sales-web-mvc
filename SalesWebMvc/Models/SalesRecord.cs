using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int MyProperty { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, int myProperty, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            MyProperty = myProperty;
            Status = status;
            Seller = seller;
        }
    }
}
