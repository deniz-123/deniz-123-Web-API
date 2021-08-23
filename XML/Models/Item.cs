using System;
namespace XML.Models
{
    public class Item
    {
        public string ID { get; set; }
        public string UUID { get; set; }
        public DateTime IssueDate { get; set; }
        public long SupplierVKN { get; set; }
        public long Customer { get; set; }
        public double TotalAmount { get; set; }

        public override string ToString()
        {
            return ID + " - " + UUID + " - " + IssueDate.ToString() + " - " + SupplierVKN.ToString() + " - " + Customer.ToString() + " - " + TotalAmount.ToString();
        }
    }
}
