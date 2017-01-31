using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenusServer.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public MenuCard MenuCard { get; set; }
        public int MenuCardId { get; set; }
    }
}
