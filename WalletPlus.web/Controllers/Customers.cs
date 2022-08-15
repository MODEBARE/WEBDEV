using WalletPlus.web.Data;
using WalletPlus.web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WalletPlus.web.Controllers
{
    public class CustomerController : Controller
    {
        public ApplicationDbContext _db;

        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            IEnumerable<Customer> objList = _db.Customer;
            return View(objList);

        }
        public IActionResult Create()
        {
            return View();
        }
        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer obj)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Add(obj);
                //_db.Customers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        //// GET Delete
        //public IActionResult Delete(int? id)
        //{

        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var obj = _db.Customers.Find(id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(obj);

        //}
        //    // POST Delete
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public IActionResult DeletePost(int? id)
        //    {
        //        var obj = _db.Customers.Find(id);
        //        if (obj == null)
        //        {
        //            return NotFound();
        //        }

        //        _db.Customers.Remove(obj);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");

        //    }
        //    // GET Update
        //    public IActionResult Update(int? id)
        //    {

        //        if (id == null || id == 0)
        //        {
        //            return NotFound();
        //        }
        //        var obj = _db.Customers.Find(id);
        //        if (obj == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(obj);

        //    }
        //    // POST-Create
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public IActionResult Update(Customer obj)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _db.Customers.Update(obj);
        //            _db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //        return View(obj);

        //    }
        //}
    }

}

