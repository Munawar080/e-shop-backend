using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using E_ShopBackend.Models;

namespace E_ShopBackend.Controllers.API_s
{
    public class CategoryController : ApiController
    {
        private ApplicationDbContext _context;
        public CategoryController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/category

        //public IHttpActionResult Get()
        //{
            
        //}
    }
}
