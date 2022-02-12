using InveonUrunApp.BusinessOperators;
using InveonUrunApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InveonUrunApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Home()
        {
            var activeUser = Session["ActiveUser"];
            if (activeUser == null)
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }

        public JsonResult GetProductList()
        {
            var result = new HomeOperator().GetProductList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult AdminCheck()
        {
            var userName = Session["ActiveUser"].ToString();
            var result = new HomeOperator().AdminCheck(userName);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetProductDetail(int Id)
        {
            var result = new HomeOperator().GetProductDetail(Id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult InsertProduct(Product product)
        {
            var result = new HomeOperator().InsertProduct(product);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult InsertProductDetail(ProductDetail product)
        {
            var result = new HomeOperator().ProductsDetailAdd(product);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult UpdateProductDetail(ProductDetail product)
        {
            var result = new HomeOperator().UpdateProductDetail(product);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteProduct(int Id)
        {
            var result = new HomeOperator().DeleteProduct(Id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}