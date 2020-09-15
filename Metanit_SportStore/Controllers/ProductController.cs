using System;
using Metanit_SportStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Metanit_SportStore.Controllers
{
    public class ProductController: Controller
    {

        private IProductRepository repository;

        ProductController(IProductRepository repo)
        {
            this.repository = repo;
        }

        public ViewResult List() => View(repository.Products);

    }
}
