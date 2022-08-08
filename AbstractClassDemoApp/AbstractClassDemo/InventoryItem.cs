// Abstract Class = a class that's a base/foundational class that you build upon (it's not complete on its own)

namespace AbstractClassDemo
{
    // you inheret from abstract classes but you do not have instances of it
    public abstract class InventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }

    }
}
