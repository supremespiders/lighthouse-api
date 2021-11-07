namespace lighthouse_api.Models
{
    public class BnrOutput
    {
        public string Currency { get; set; }
        public string Date { get; set; }
        public decimal BuyingValue { get; set; }
        public decimal AverageValue { get; set; }
        public decimal SellingValue { get; set; }
    }
}