using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        private int PageSize = 2;
        public ProductController(IProductRepository repo)
        {
            this.repository = repo;
        }
        public ViewResult List(int currentPage = 1) =>
            View(new ProductsListViewModel
            {
                Products = repository.Products
                            .OrderBy(p => p.ProductID)
                            .Skip((currentPage - 1) * PageSize)
                            .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = currentPage,
                    ItemPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
    }
}