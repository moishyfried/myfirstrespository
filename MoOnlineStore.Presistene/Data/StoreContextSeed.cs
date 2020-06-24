using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MoOnlineStore.Presistene
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {

            //        if (!context.ProductsTypes.Any())
            //        {
            //            var brandsData =
            //                File.ReadAllText("../MoOnlineStore.Presistene/Data/SeedData/brands.json");

            //            var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

            //            foreach (var item in brands)
            //            {
            //                context.ProductsBrands.Add(item);
            //            }

            //            await context.SaveChangesAsync();
            //        }

            //        if (!context.ProductsTypes.Any())
            //        {
            //            var typesData =
            //                File.ReadAllText("../MoOnlineStore.Presistene/Data/SeedData/types.json");

            //            var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

            //            foreach (var item in types)
            //            {
            //                context.ProductsTypes.Add(item);
            //            }

            //            await context.SaveChangesAsync();
            //        }

            //        if (!context.Products.Any())
            //        {
            //            var productsData =
            //                File.ReadAllText("../MoOnlineStore.Presistene/Data/SeedData/products.json");

            //            var products = JsonSerializer.Deserialize<List<Products>>(productsData);

            //            foreach (var item in products)
            //            {
            //                context.Products.Add(item);
            //            }

            //            await context.SaveChangesAsync();
            //        }
            //    try
            //    { }
            //    catch (Exception ex)
            //    {
            //        var logger = loggerFactory.CreateLogger<StoreContextSeed>();
            //        logger.LogError(ex.Message);
            //    }
            //}
        }
    }
}