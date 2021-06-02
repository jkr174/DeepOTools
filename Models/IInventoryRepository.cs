using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepOTools.Models
{
    public interface IInventoryRepository
    {
        IQueryable<Inventory> Inventories { get; }
    }
}
