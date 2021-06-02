using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DeepOTools.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            InventoryDbContext context = app.ApplicationServices
                .GetRequiredService<InventoryDbContext>();
            context.Database.Migrate();
            if (!context.Inventories.Any())
            {
                context.Inventories.AddRange(
                    new Inventory
                    {
                        ItemName = "36V Cordless Chainsaw 12 inches",
                        Description = "The 36V LXT® Lithium-Ion Cordless Chain Saw Kit is the lightest weight chainsaw option and allows the operator freedom to work on light yard work without being connected to a power source.",
                        Catagory = "Lawn and Garden Equipment",
                        Subcategory = "Chainsaw",
                        Price = 16.99
                    }
                    );
            }
        }
    }
}
