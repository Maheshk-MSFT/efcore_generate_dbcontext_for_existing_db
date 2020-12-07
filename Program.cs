
using efcore_generate_dbcontext_for_existing_db.Models;
using System;
using System.Linq;

namespace efcore_generate_dbcontext_for_existing_db
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code sample -efcore_generate_dbcontext_from_existing_db");

            MikkyContext context = new MikkyContext();

            var products = context.Products.Where(p => p.Price >= 3.00m).OrderBy(p => p.Name);

            foreach (Product p in products)
            {
                Console.WriteLine("\t Product name->"+p.Name + "| price->" + p.Price);
            }
        }
    }
}
