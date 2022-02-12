using InveonUrunApp.Context;
using InveonUrunApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Logic
{
    public class HomeLogic
    {
        private InveonContext context = null;

        public HomeLogic()
        {
            context = new InveonContext();
        }
        public List<Product> GetProductList()
        {
            try
            {
                var productList = context.Product.ToList();
                foreach (var item in productList)
                {
                    item.ProductDetail = GetProductDetail(item.Id);
                }
                return productList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ProductDetail GetProductDetail(int Id)
        {
            try
            {
                var product= context.ProductDetail.Where(x=> x.ProductId == Id).FirstOrDefault();
                
                return product;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Product ProductsAdd(Product product)
        {
            try
            {
                var result = context.Product.Add(product);
                context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        } 
        
        public ResponseBaseEntity ProductsDetailAdd(ProductDetail productDetail)
        {
            ResponseBaseEntity response = new ResponseBaseEntity();
            try
            {
                Product product = new Product
                {
                    ProductName = productDetail.ProductName,
                    CreateDate = DateTime.Now,
                    Status = Convert.ToInt32(true)
                };

                var insertProduct = ProductsAdd(product);

                productDetail.ProductId = insertProduct.Id;
                var result = context.ProductDetail.Add(productDetail);
                context.SaveChanges();
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                return response;
            }
        }

        public ResponseBaseEntity UpdateProductDetail(ProductDetail product)
        {
            ResponseBaseEntity response = new ResponseBaseEntity();
            try
            {
                var result = context.ProductDetail.Where(x=> x.Id == product.Id).FirstOrDefault();

                result.Image = product.Image;
                result.Price = product.Price;
                result.Quantity = product.Quantity;
                result.Description = product.Description;
                result.Barcode = product.Barcode;

                context.SaveChanges();

                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                return response;
            }
        }

        public ResponseBaseEntity DeleteProduct(int Id)
        {
            ResponseBaseEntity result = new ResponseBaseEntity();
            try
            {
                var product = context.Product.Where(x => x.Id == Id).FirstOrDefault();
                var productDetail = context.ProductDetail.Where(x => x.ProductId == product.Id).FirstOrDefault();
                context.Product.Remove(product);
                context.ProductDetail.Remove(productDetail);
                context.SaveChanges();

                result.Success = true;
                return result;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.ErrorMessage = ex.Message;
                return result;
            }
        }
    }
}