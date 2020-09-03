using System;

namespace OpenClosedPrinciple
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Yuge
    }

    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };
            var bf = new BetterFilter();
            Console.WriteLine("Green products:");

            foreach (var p in bf.Filter(products,
                    new AndSpecification<Product>(
                    new ColorSpecification(Color.Green),
                    new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {p.Name} is {nameof(Size.Large)} and {nameof(Color.Green)}");
            }
        }
    }
}