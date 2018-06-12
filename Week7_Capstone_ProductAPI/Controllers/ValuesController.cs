using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Week7_Capstone_ProductAPI.Models;

namespace Week7_Capstone_ProductAPI.Controllers
{
    
    public class ValuesController : ApiController
    {

        //1. GET List of Products by ProductIDs
        [HttpGet]
        public List<Product> GetProductByID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Product> productids = db.Products.ToList();
            return productids;
        }

        //3. Return list of all Product Information
        [HttpGet]
        public List<Product> GetProductByID()
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Product> prod = db.Products.ToList();
            return prod;
        }

        ////Get Single Product by ProductID
        //public string[] GetProductByID(int id)
        //{
        //    NorthwindEntities db = new NorthwindEntities();
        //    List<Product> prod = db.Products.ToList();
        //    string[] prodArray = new string[prod.Count];

        //    for (int i = 0; i; prodArray; i++)
        //    {
        //        prodArray[i] = $"Prod id = {prod[i].ProductID} prodname = {prod[i].ProductName}";
        //    }
        //    return prodArray;
        //}

        //2. Get List of Products by Name
        public List<Product> GetProductByName(string id)
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Product> prodname = (from p in db.Products
                                      where p.ProductName == id
                                      select p).ToList();
            return prodname;
        }

        //Extended Challenge. Get Product by Category by calling specific ID
        public List<Product> GetProductByCategoryID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Product> categoryID = (from p in db.Products
                                        where p.CategoryID == id
                                        select p).ToList();
            return categoryID;
        }

        //Extended Challenge by SupplierID
        public List<Product> GetProductBySupplierID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Product> supplierID = (from p in db.Products
                                        where p.SupplierID == id
                                        select p).ToList();
            return supplierID;
        }

        //Extended Challenge by Max Price
        //Don't know how to use Max<>
        public List<Product> GetMaxPrice(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Product> maxprice = (from p in db.Products
                                        where p.UnitPrice == id
                                        select p).ToList();
            return maxprice;
        }
    }
}
