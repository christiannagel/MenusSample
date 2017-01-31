using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenusServer.Models
{
    public class MenuCard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<MenuItem> MenuItems { get; set; }
    }
}
