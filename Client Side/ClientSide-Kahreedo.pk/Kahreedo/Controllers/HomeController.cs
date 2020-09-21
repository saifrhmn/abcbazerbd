using Khareedo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Khareedo.Models.GenericInterface;
using Khareedo.Models.GenericRepository;


namespace Khareedo.Controllers
{
    public class HomeController : Controller
    {

        private IGenericRepository<Product> repository = null;

        public HomeController()
        {
            this.repository = new GenericRepository<Product>();
        }

        public HomeController(IGenericRepository<Product> repository)
        {
            this.repository = repository;
        }

        // GET: Home
        public ActionResult Index()
        {
            var model = repository.GetAll();
            ViewBag.MenProduct = model.Where(x => x.Category.Name.Equals("Men")).ToList(); 
            ViewBag.WomenProduct = model.Where(x => x.Category.Name.Equals("Women")).ToList();
            ViewBag.SportsProduct = model.Where(x => x.Category.Name.Equals("Sports")).ToList();
            ViewBag.ElectronicsProduct = model.Where(x => x.Category.Name.Equals("Phones")).ToList();
            //ViewBag.Slider = db.genMainSliders.ToList();
            //ViewBag.PromoRight = db.genPromoRights.ToList();

            this.GetDefaultData();

            return View();
        }
        /*
        KhareedoEntities db = new KhareedoEntities();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MenProduct = db.Products.Where(x => x.Category.Name.Equals("Men")).ToList();
            ViewBag.WomenProduct = db.Products.Where(x => x.Category.Name.Equals("Women")).ToList();
            ViewBag.SportsProduct = db.Products.Where(x => x.Category.Name.Equals("Sports")).ToList();
            ViewBag.ElectronicsProduct = db.Products.Where(x => x.Category.Name.Equals("Phones")).ToList();
            ViewBag.Slider = db.genMainSliders.ToList();
            ViewBag.PromoRight = db.genPromoRights.ToList();

            this.GetDefaultData();

            return View();
        }
        */




    }
}