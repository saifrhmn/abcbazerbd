using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Khareedo.Models;
using System.Data;
using Khareedo.Models.GenericInterface;
using Khareedo.Models.GenericRepository;

namespace Khareedo.Controllers
{
    public class AccountController : Controller
    {
        private IGenericRepository<Customer> repository = null;

        public AccountController()
        {
            this.repository = new GenericRepository<Customer>();
        }

        public AccountController(IGenericRepository<Customer> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            this.GetDefaultData();
            var model = repository.GetById(TempShpData.UserID);
            return View(model);
        }

        //REGISTER CUSTOMER
        [HttpPost]
        public ActionResult Register(Customer model)
        {
            if (ModelState.IsValid)
            {
                repository.Insert(model);
                repository.Save();
                Session["username"] = model.UserName;
                TempShpData.UserID = repository.GetById(model.UserName).CustomerID;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        
        //LOG IN
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection formColl)

        {
            string usrName = formColl["UserName"];
            string Pass = formColl["Password"];

            if (ModelState.IsValid)
            {
                int cust = repository.GetById(usrName).CustomerID;
                if (cust != 0)
                {
                    TempShpData.UserID = repository.GetById(usrName).CustomerID;
                    Session["username"] = repository.GetById(usrName).UserName;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        //LOG OUT
        public ActionResult Logout()
        {
            Session["username"] = null;
            TempShpData.UserID = 0;
            TempShpData.items = null;
            return RedirectToAction("Index", "Home");
        }



        public Customer GetUser(string _usrName)
        {
            var model = repository.GetAll();
            var cust = (from c in model
                        where c.UserName == _usrName
                        select c).FirstOrDefault();
            return cust;
        }

        //UPDATE CUSTOMER DATA
        [HttpPost]
        public ActionResult Update(Customer cust)
        {
            if (ModelState.IsValid)
            {
                repository.Update(cust);
                repository.Save();
                Session["username"] = cust.UserName;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        /*
        KhareedoEntities db = new KhareedoEntities();
        // GET: Account
        public ActionResult Index()
        {
            this.GetDefaultData();

            var usr = db.Customers.Find(TempShpData.UserID);
            return View(usr);

        }


        //REGISTER CUSTOMER
        [HttpPost]
        public ActionResult Register(Customer cust)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(cust);
                db.SaveChanges();

                Session["username"] = cust.UserName;
                TempShpData.UserID = GetUser(cust.UserName).CustomerID;          
                return RedirectToAction("Index","Home");
            }
            return View();
        }
       
        //LOG IN
        public ActionResult Login()
        {
            return View();
        }

         [HttpPost]
        public ActionResult Login(FormCollection formColl)

        {
            string usrName = formColl["UserName"];
            string Pass = formColl["Password"];

            if (ModelState.IsValid)
            {
                var cust = (from m in db.Customers
                            where (m.UserName == usrName && m.Password == Pass)
                            select m).SingleOrDefault();

                if (cust !=null )
                {
                    TempShpData.UserID = cust.CustomerID;
                    Session["username"] = cust.UserName;
                    return RedirectToAction("Index", "Home");
                }
                      
            }
            return View();
        }

        //LOG OUT
         public ActionResult Logout()
         {
             Session["username"] = null;
             TempShpData.UserID = 0;
             TempShpData.items = null;
             return RedirectToAction("Index", "Home");
         }

       

        public Customer GetUser(string _usrName)
        {
            var cust = (from c in db.Customers
                        where c.UserName == _usrName
                        select c).FirstOrDefault();
            return cust;
        }

        //UPDATE CUSTOMER DATA
        [HttpPost]
        public ActionResult Update(Customer cust)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cust).State = EntityState.Modified;
                db.SaveChanges();
                Session["username"] = cust.UserName;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        */
    }
}