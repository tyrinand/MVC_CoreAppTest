using System;

namespace SaleSoft.ViewModels
{
    public class SaleViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public string Clientfio { get; set; }
        public string DescountName { get; set; }
        public decimal DescountValue { set; get; }
        public string SoftName { get; set; }
        public decimal SoftPrice { get; set; }
        public string ShopName { get; set; }
        public decimal Сost => (Count * SoftPrice) * (100.0M - DescountValue);
    }
}
