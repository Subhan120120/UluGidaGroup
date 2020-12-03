using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public HomeController(  IRepository<AppDetail> appDetailRepo,
                                IRepository<Product> productRepo,
                                IRepository<ProductGroup> productGroupRepo)
        {                                                          
            this.appDetailRepo = appDetailRepo;
            this.productRepo = productRepo;
            this.productGroupRepo = productGroupRepo;
        }

        public IActionResult Index()
        {
            var prod = productGroupRepo.GetAll().Include(x => x.Products).Where(x => x.Products.Any()).ToList();
            return View(prod);
        }

        public IActionResult Shop()
        {
            return View();
        }       
        public IActionResult Blog()
        {
            return View();
        }
    }
}
