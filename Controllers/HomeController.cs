using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UluGidaGroup.AppCode.Infrastructure;
using UluGidaGroup.Models.Entity;

namespace UluGidaGroup.Controllers
{
    public class HomeController : Controller
    {
        public readonly IRepository<AppDetail> appDetailRepo;
        public readonly IRepository<Product> productRepo;
        public readonly IRepository<ProductGroup> productGroupRepo;
        public readonly IRepository<Dealer> dealerRepo;

        public HomeController(IRepository<AppDetail> appDetailRepo,
                                IRepository<Product> productRepo,
                                IRepository<ProductGroup> productGroupRepo,
                                IRepository<Dealer> dealerRepo)
        {
            this.appDetailRepo = appDetailRepo;
            this.productRepo = productRepo;
            this.productGroupRepo = productGroupRepo;
            this.dealerRepo = dealerRepo;
        }

        public IActionResult Index()
        {
            List<ProductGroup> products = productGroupRepo.GetAll().Include(x => x.Products).Where(x => x.Products.Any()).ToList();
            return View(products);
        }

        public IActionResult Dealers()
        {
            List<Dealer> dealers = dealerRepo.GetAll().OrderBy(x => x.OrderNumber).ToList();
            return View(dealers);
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
    }
}
