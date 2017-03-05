
namespace models
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public bool isActive { get; set; }
        public string unit { get; set; }
        public string item_type { get; set; }
        public bool is_taxable { get; set; }
        public string tax_id { get; set; }
        public string description { get; set; }
        public string attribute_name1 { get; set; }
        public int rate { get; set; }
        public int purchase_rate { get; set; }
        public int reorder_level { get; set; }
        public int initial_stock { get; set; }
        public int initial_stock_rate { get; set; }
        public string vendor_name { get; set; }
        public string sku { get; set; }
        public string upc { get; set; }
        public string ean { get; set; }
        public string isbn { get; set; }
        public string part_number { get; set; }
        public string attribute_option_name1 { get; set; }
        public string purchase_description { get; set; }
    }
}
   
