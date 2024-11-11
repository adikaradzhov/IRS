using IRS.Models.Enums;

namespace IRS.Models
{
    public class Table
    {
        public string ID { get; set; }
        public TableStatus Status { get; set; }
        public virtual Order Order { get; set; }

        public Table()
        {
            Order = new Order();
        }
        public Table(string id,TableStatus status )
        {
            ID = id;
            Status = status;
            Order = new Order();
        }
    }
}
