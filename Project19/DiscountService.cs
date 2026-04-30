using Project19;

public static class DiscountService
{
    public static double GetDiscountedPrice(Product product)
    {
        // Modern C# Switch Expression with Pattern Matching
        return product.Category switch
        {
            "Electronics" when product.Price > 1000 => product.Price * 0.90, // 10% off
            "Electronics" => product.Price * 0.95,                          // 5% off
            "Food" => product.Price * 0.80,                                 // 20% off
            _ => product.Price                                              // Default: No discount
        };
    }
}