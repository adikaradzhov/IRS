namespace IRS.Models
{
    public class StorageItem
    {
        string ID { get; set; }
        public string Name { get; set; }
        public int Count {  get; set; }

        public StorageItem(string id, string name, int count)
        {
            ID = id;
            Name = name;
            Count = count;
        }
    }
}
