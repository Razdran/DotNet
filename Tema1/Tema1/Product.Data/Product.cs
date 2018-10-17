using System;

namespace Product.Data
{
    public class Product
    {
        public Product()
        {
            
        }
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public double VAT { get; set; }
        public bool IsValid()
        {
            if (DateTime.Compare(StartDate,EndDate)<0)
                return true;
            return false;
        }
        public double ComputeVAT()
        {
            return VAT/ 100 * Price + Price;
        }

    }
}
