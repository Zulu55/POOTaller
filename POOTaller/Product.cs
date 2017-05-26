namespace POOTaller
{
    public abstract class Product
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public abstract decimal GetValue();

        public override string ToString()
        {
            return string.Format("{0} {1}", Id, Description); 
        }
    }
}
