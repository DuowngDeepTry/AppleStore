using AppleStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AppleStore.Controllers
{
    public class CartController : Controller
    {
        AppleStoreEntities db = new AppleStoreEntities();
        // GET: Cart
        public ActionResult Index()
        {
            return View((List<Cart>)Session["cart"]);
        }
        public ActionResult AddToCart(int id, int quantity)
        {
            if (Session["cart"] == null)
            {
                List<Cart> cart = new List<Cart>();
                cart.Add(new Cart { San_Pham = db.San_Pham.Find(id), Quantity = quantity });
                Session["cart"] = cart;
                Session["count"] = 1;
            }
            else
            {
                List<Cart> cart = (List<Cart>)Session["cart"];
                // kiem tra san pha co ton tai trong gio hang chua
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity += quantity;
                }
                else
                {
                    cart.Add(new Cart { San_Pham = db.San_Pham.Find(id), Quantity = quantity });
                    Session["count"] = Convert.ToInt32(Session["count"]) + 1;

                }
                Session["cart"] = cart;
            }
            return Json(new { Message = "Thành Công", JsonRequestBehavior.AllowGet });
        }

        private int isExist(int id)
        {
            List<Cart> cart = (List<Cart>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].San_Pham.id.Equals(id))
                    return i;
            }
            return -1;
        }
        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<Cart>>(cartModel);
            var cart = (List<Cart>)Session["cart"];
            foreach (var item in cart)
            {
                var jsonItem = jsonCart.SingleOrDefault(n => n.San_Pham.id == item.San_Pham.id);
                if (jsonItem != null)
                {
                    item.Quantity = jsonItem.Quantity;

                }
            }
            Session["cart"] = cart;
            return Json(new
            {
                status = true
            });
        }
        public JsonResult Remove(int id)
        {
            var cart = (List<Cart>)Session["cart"];
            cart.RemoveAll(n => n.San_Pham.id == id);
            Session["cart"] = cart;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            return Json(new
            {
                status = true
            });
        }

    }
}