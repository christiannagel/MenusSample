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
    public class MenuCardsController : Controller
    {
        private readonly MenuCardContext _context;
        public MenuCardsController(MenuCardContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<MenuCard> GetMenuCards()
        {
            return _context.MenuCards.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public MenuCard GetMenuCard(int id)
        {
            return _context.MenuCards.Single(c => c.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]MenuCard value)
        {
            _context.MenuCards.Add(value);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]MenuCard value)
        {
            _context.MenuCards.Update(value);
            _context.SaveChanges();
        }

    }
}
