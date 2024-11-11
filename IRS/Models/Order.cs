namespace IRS.Models
{
    public class Order
    {
        public string ID { get; set; }
        public double Price { get; set; }
        public string WaiterID {  get; set; }
        public string TableID {  get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<Cook> Cooks { get; set; }

        public Order()
        {
            Products = new List<Product>();
            Cooks = new List<Cook>();
        }

        public Order(string id, double price, string waiterID, string tableID)
        {
            ID = id;
            Price = price;
            WaiterID = waiterID;
            TableID = tableID;
            Products = new List<Product>();
            Cooks = new List<Cook>();
        }
    }
}
