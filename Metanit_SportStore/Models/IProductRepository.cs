using System;
using System.Collections.Generic;

namespace Metanit_SportStore.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
