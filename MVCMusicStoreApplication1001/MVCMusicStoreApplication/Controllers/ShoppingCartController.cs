﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class ShoppingCartController : Controller
    {
        MVCMusicStoreDB db = new MVCMusicStoreDB();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);

            ShoppingCartViewModel vn = new ShoppingCartViewModel()
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetCartTotal()
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

            Album album = db.Carts.SingleOrDefault(c => c.RecordId == id).AlbumSelected;
            int newItemCount = cart.RemoveFromCart(id);
            cart.RemoveFromCart(id);

            ShoppingCartRemoveViewModel vm = new ShoppingCartRemoveViewModel()
            {
                DeleteId = id,
                CartTotal = cart.GetCartTotal(),
                ItemCount = newItemCount,
                Message = "Your Album was removed from the cart."
            };

            return Json(vm);
            
        }

    }
}