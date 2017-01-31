using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MenusServer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenusServer.Controllers
{
    [Route("api/[controller]")]
    public class MenuItemsController : Controller
    {
        private readonly MenuCardContext _context;
        public MenuItemsController(MenuCardContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<MenuItem> GetMenuItems()
        {
            return _context.MenuItems.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public MenuItem GetMenuItem(int id)
        {
            return _context.MenuItems.Single(mi => mi.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]MenuItem value)
        {
            _context.MenuItems.Add(value);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]MenuItem value)
        {
            _context.MenuItems.Update(value);
            _context.SaveChanges();
        }

    }
}
