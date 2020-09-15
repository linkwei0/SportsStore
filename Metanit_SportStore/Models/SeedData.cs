using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Metanit_SportStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder арр)
        {
            ApplicationContext context = арр.ApplicationServices.GetRequiredService<ApplicationContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "А boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                new Product
                {
                    Name = "Lifejacket",
                    Description = "Protective and fashionaЫe",
                    Category = "Watersports ",
                    Price = 48.95m
                },
                new Product
                {
                    Name = "Soccer Ball",
                    Description = "FIFA-approved size and weight",
                    Category = "Soccer",
                    Price = 19.50m
                },
                new Product
                {
                    Name = "Corner Flags",
                    Description = "Give your pl aying f ield а prof essional t ouch",
                    Category = "Soccer",
                    Price = 34.95m
                },
                new Product
                {
                    Name = "Stadium",
                    Description = "Fl at-packed 35, 000- seat stadi um",
                    Category = "Soccer",
                    Price = 79500
                },
                new Product
                {
                    Name = "Thinking Сар",
                    Description = "Improve brain efficiency Ьу 75%",
                    Category = "Chess",
                    Price = 16
                },
                new Product
                {
                    Name = "Unsteady Chair",
                    Description = "Secretly give your opponent а disadvantage",
                    Category = "Chess",
                    Price = 29.95m
                },
                new Product
                {
                    Name = "Human Chess Board",
                    Description = "А fun game for the family",
                    Category = "Chess",
                    Price = 75
                },
                new Product
                {
                    Name = "Bling-Bling King",
                    Description = "Gold-plated, diamond-st udded King",
                    Category = "Chess",
                    Price = 1200
                }
                );
                context.SaveChanges();
            }
        }
    }
}
