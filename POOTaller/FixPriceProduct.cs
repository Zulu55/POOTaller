namespace POOTaller
{
    public class FixPriceProduct : Product
    {
        public decimal Price { get; set; }

        public override decimal GetValue()
        {
            return Price;
        }

        public override string ToString()
        {
            return string.Format(@"{0}
Value...............: {1,12:C2}", 

base.ToString(), GetValue());
        }
    }
}
