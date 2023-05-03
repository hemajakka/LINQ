namespace Linq_assignment
{
    class product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string brand { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }

        static void SeedData(List<product> products)
        {
           products.Add( new product { Id = "p001", Name = "laptop", brand = "dell", quantity = 5, price = 35000 });
           products.Add( new product { Id = "p002", Name = "camera", brand = "canon", quantity = 8, price = 28500 });
            products.Add(new product { Id = "p003", Name = "tablet", brand = "lenvo", quantity = 4, price = 15000 });
           products.Add( new product { Id = "p004", Name = "mobile", brand = "apple", quantity = 9, price = 65000 });
            products.Add(new product { Id = "p005", Name = "earphones", brand = "boat", quantity = 2, price = 1500 });
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<product> products = new List<product>();
                SeedData(products);
                Console.WriteLine("price between 20000 and 40000");
                var query1 = from p in products where p.price >= 20000 && p.price <= 40000 select p;
                foreach (var item in query1)
                {
                    Console.WriteLine($" {item.Name} ");
                }
                Console.WriteLine("product name cointains a");
                var query2 = products.Where(x => x.Name.Contains("a")).ToList();
                foreach (var item in query2)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.brand} {item.quantity} {item.price}");
                }
                Console.WriteLine("ascending order");
                var res1 = products.OrderBy(x => x.Name).ToList();
                foreach (var item in res1)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.brand} {item.quantity} {item.price}");
                }

                var res2 = products.Max(x => x.price);
                Console.WriteLine($"highest price is {res2}");
                var res3 = products.Any(x => x.Id == "p003");
                Console.WriteLine(res3);
            }
        }
    }
}