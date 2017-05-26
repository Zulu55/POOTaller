namespace POOTaller
{
    public class VariablePriceProduct : Product
    {
        public string MesumeasurementUnit { get; set; }

        public decimal MesumeasurementUnitPrice { get; set; }

        public double Quantity { get; set; }

        public override decimal GetValue()
        {
            return MesumeasurementUnitPrice * (decimal)Quantity;
        }

        public override string ToString()
        {
            return string.Format(@"{0}
Mesumeasurement unit: {1}
Quantity............: {2,12:N2}
Unit price..........: {3,12:C2}
Value...............: {4,12:C2}", 
base.ToString(), MesumeasurementUnit, Quantity, MesumeasurementUnitPrice, GetValue());
        }
    }
}
