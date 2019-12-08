using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventProject.Models;

namespace EventProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        EventProjectDB db = new EventProjectDB();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);

            ShoppingCartViewModel vn = new ShoppingCartViewModel()
            {
                CartItems = cart.GetCartItems(),

            };

            return View(vn);
        }

        // GET ShoppingCart/AddToCart
        public ActionResult AddToCart(int id)
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            cart.AddToCart(id);
            return RedirectToAction("Index");
        }

        //POST: ShoppingCart/RemoveFromCart
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);

            Event evente = db.Carts.SingleOrDefault(c => c.RecordId == id).EventSelected;
            int newItemCount = cart.RemoveFromCart(id);
            cart.RemoveFromCart(id);

            ShoppingCartRemoveViewModel vm = new ShoppingCartRemoveViewModel()
            {
                DeleteId = id,
                ItemCount = newItemCount,
                Message = "Your Album was removed from the cart."
            };

            return Json(vm);

        }

    }
}