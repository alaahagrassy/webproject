using Graduation_project3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Graduation_project3.Controllers
{
    public class SuppliesController : ApiController
    {
        public Project db = new Project();
        // GET: api/Supplies
        public IQueryable<Supply> GetSupplies()
        {
            return db.Supplies;
        }
    }
}
