using MVCDATAsharing.Models;
using System;
using System.Web.Mvc;

namespace MVCDATAsharing.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult GetProductInfo()
        {
            return View();
        }

        //Form Collection
        //[HttpPost]
        //public ActionResult GetProductInfo(FormCollection frmObj)
        //{
        //    int id = Convert.ToInt16(frmObj["productId"]);
        //    string name = frmObj["productName"];
        //    double price = Convert.ToDouble(frmObj["productCost"]);
        //    Response.Write($"{id}  -  {name}  -  {price}");
        //    return View();
        //}



        //Formal Parameter
        //[HttpPost]
        //public ActionResult GetProductInfo(int productId, string ProductName, double productCost)
        //{
        //    Response.Write($"{productId}    -   {ProductName}   -   {productCost}");
        //    return View();
        //}

       // Model Class Object (99% use this approach)
        [HttpPost]
        public ActionResult GetProductInfo(Product obj)
        {
            Response.Write($"{obj.ProductId}    -   {obj.ProductName}   -   {obj.ProductCost}");
            return View();
        }
        public ActionResult GetProduct()
        {
            return View();
        }
        public ContentResult GetProductName(string id) 
        {

            return Content("Product Name is: " + id);
        }
        public ContentResult GetNameAndPrice(string name, double price)
        {
            string info = $"ProductName is: {name} and Price is: {price}";
            return Content(info);
        }
    }
}