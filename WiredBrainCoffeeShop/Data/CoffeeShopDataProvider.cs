namespace WiredBrainCoffeeShop.Data
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadShops()
        {
            return new CoffeeShop[]
            {
                new CoffeeShop("Frankfaut", 45),
                new CoffeeShop("Zuich", 39),
                new CoffeeShop("Rome", 25)
            }
        }
    }
}
