using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using E_ShopBackend.Models;
using E_ShopBackend.DTO_s;
using AutoMapper;
namespace E_ShopBackend.Controllers.API_s
{
    public class ProductsController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public ProductsController()
        {
            _dbContext = new ApplicationDbContext();
        }


        public IEnumerable<ProductDTO> GetProducts()
        {
            return _dbContext.Products.ToList().Select(Mapper.Map<Product, ProductDTO>);
        }

        [HttpPost]
        public IHttpActionResult CreateProduct(ProductDTO productDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var product = Mapper.Map<ProductDTO, Product>(productDto);

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            productDto.Id = product.Id;

            return Created(new Uri(Request.RequestUri + "/" + product.Id), productDto);
        }


        public IHttpActionResult GetProduct(int id)
        {
            var product = _dbContext.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
                return BadRequest();
            
            return Ok(Mapper.Map<Product, ProductDTO>(product)); 
        }



        [HttpPut]
        public void PutProduct(int id, ProductDTO productDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var product = _dbContext.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(productDto, product);

            _dbContext.SaveChanges();

        }

        [HttpDelete]
        public void DeleteProduct(int id)
        {
            var productinDb = _dbContext.Products.SingleOrDefault(p => p.Id == id);

            if (productinDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _dbContext.Products.Remove(productinDb);
            _dbContext.SaveChanges();
        }
    }
}
