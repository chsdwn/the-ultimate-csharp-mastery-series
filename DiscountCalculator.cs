namespace ultimate_csharp_mastery
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price * 0.05f;
        }
    }
}