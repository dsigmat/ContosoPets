using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoPets.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ContosoPetsContext(
                serviceProvider.GetRequiredService<DbContextOptions<ContosoPetsContext>>()))
            {
                if (context.Product.Any())
                {
                    return;
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Squeaky Bone",
                        Price = 20.99m
                    },

                    new Product
                    {
                        Name = "Knotted Rope",
                        Price = 12.99m
                    }
                );
                context.SaveChanges();
            }
            
        }
    }
}
