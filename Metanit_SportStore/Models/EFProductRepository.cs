using System;
using System.Collections.Generic;

namespace Metanit_SportStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationContext context;

        public EFProductRepository(ApplicationContext ct)
        {
            this.context = ct;
        }

        public IEnumerable<Product> Products => context.Products;
    }
}
