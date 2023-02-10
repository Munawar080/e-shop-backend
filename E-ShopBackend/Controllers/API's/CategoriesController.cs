using E_ShopBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using E_ShopBackend.DTO_s;
using AutoMapper;

namespace E_ShopBackend.Controllers.API_s
{
    public class CategoriesController : ApiController
    {
        private ApplicationDbContext _context;
        public CategoriesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/categories

        public IEnumerable<CategoriesDTO> GetCategories()
        {
            return _context.Categories.ToList().Select(Mapper.Map<Categories, CategoriesDTO>);
        }

        // GET /api/categories/id
        public CategoriesDTO GetCategory(int id)
        {
            var category = _context.Categories.SingleOrDefault(c => c.Id == id);

            if (category == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            return Mapper.Map<Categories, CategoriesDTO>(category);
        }

        // POST /api/catgories
        [HttpPost]
        public CategoriesDTO CreateCategory(CategoriesDTO categoriesDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var category = Mapper.Map<CategoriesDTO, Categories>(categoriesDto);
            _context.Categories.Add(category);
            _context.SaveChanges();
            categoriesDto.Id = category.Id;
            return categoriesDto;

        }

        // PUT /api/categories/id
        [HttpPut]
        public void UpateCategories(int id, CategoriesDTO categoriesDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var categoryinDB = _context.Categories.SingleOrDefault(c => c.Id == id);

            if (categoryinDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

           var cat =  Mapper.Map(categoriesDto, categoryinDB);

            _context.SaveChanges();
        }

        // DELETE /api/categories/id
        [HttpDelete]
        public void DeleteCategoy(int id)
        {
            var categoryInDb = _context.Categories.SingleOrDefault(c => c.Id == id);

            if (categoryInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Categories.Remove(categoryInDb);
            _context.SaveChanges();

        }
    }
}
