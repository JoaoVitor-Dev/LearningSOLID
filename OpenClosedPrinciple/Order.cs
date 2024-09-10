namespace OpenClosedPrinciple
{
    public class Order
    {
        DiscountWithSolid _discount;
        public int Id { get; set; }
        public Double Value { get; set; }

        public Order(double value)
        {
            Value = value;
        }
        public void Finish()
        {
            //var discount = new DiscountWithoutSolid();
            //Value = discount.ApplyDiscount(Value);
            if (Value > 100)
                _discount = new WholesaleDiscount();
            else
                _discount = new StandardDiscount();

            _discount.ApplyDiscount(Value);
        }
    }
}
