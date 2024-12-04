public class FoodProduct : Product
{
    public int ShelfLife { get; set; } 
    public int Quantity { get; set; }  
    public string Unit { get; set; }   

    public FoodProduct(decimal price, string originCountry, string name, DateTime packagingDate, string description,
                       int shelfLife, int quantity, string unit)
        : base(price, originCountry, name, packagingDate, description)
    {
        ShelfLife = shelfLife;
        Quantity = quantity;
        Unit = unit;
    }
}
