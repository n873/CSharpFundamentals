namespace Pizza
{
    public enum Size {
        Small, Medium, Large
    }

    public enum Crust {
        Thin, Regular, Stuffed
    }

    public class Pizza
    {
        public Size Size { get; set; }
        public Crust Crust { get; set; }
        public decimal Price { get; set; }
    }
}
