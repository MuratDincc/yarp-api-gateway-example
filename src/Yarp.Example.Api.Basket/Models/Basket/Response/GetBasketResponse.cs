namespace Yarp.Example.Api.Basket.Models.Basket.Response;

public class GetBasketResponse
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal ItemPrice { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }
    }

    public List<Item> Items { get; set; }

    public decimal Total { get; set; }
}