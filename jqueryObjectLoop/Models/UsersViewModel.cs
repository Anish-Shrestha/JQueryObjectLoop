using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jqueryObjectLoop.Models
{
    public class UsersViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UsersViewModel(int id, string name) {
            this.Id = id;
            this.Name = name;
        }
    }
}