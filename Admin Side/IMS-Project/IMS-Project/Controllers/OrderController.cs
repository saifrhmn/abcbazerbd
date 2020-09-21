using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using IMS_Project.Models;








namespace IMS_Project.Controllers
{
    public class OrderController : Controller
    {
        KahreedoEntities db = new KahreedoEntities();
        // GET: Order
        public ActionResult Index(string search)
        {
            if (search == null)
            {
                return View(db.Orders.OrderByDescending(x => x.OrderID).ToList());
            }
            else
            {
                return View(db.Orders.AsEnumerable().Where(x => x.OrderID.ToString().Contains(search)).ToList());
            }
        }

        public ActionResult Details(int id)
        {
            Order ord = db.Orders.Find(id);
            var Ord_details = db.OrderDetails.Where(x => x.OrderID == id).ToList();
            var tuple = new Tuple<Order, IEnumerable<OrderDetail>>(ord, Ord_details);

            double SumAmount = Convert.ToDouble(Ord_details.Sum(x => x.TotalAmount));
            ViewBag.TotalItems = Ord_details.Sum(x => x.Quantity);
            ViewBag.Discount = 0;
            ViewBag.TAmount = SumAmount - 0;
            ViewBag.Amount = SumAmount;
            return View(tuple);
        }

        //Get Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Order order = db.Orders.Single(x => x.OrderID == id);
            if (order == null)
            {
                return HttpNotFound();
            }

            return View("Edit", order);
        }

        //Post Edit
        [HttpPost]
        public ActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Order");
            }

            return View(order);
        }


    }
}